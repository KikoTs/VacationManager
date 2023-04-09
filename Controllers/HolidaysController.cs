using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VacationManager.Data;
using VacationManager.Models;

namespace VacationManager.Controllers
{
    [Authorize]
    public class HolidaysController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly ApplicationDbContext _db;
        public HolidaysController(ApplicationDbContext db, UserManager<AppUser> userManager)
        {
            _userManager = userManager;
            _db = db;
        }

        public async Task<IActionResult> Index()
        {
            var userRequests = _db.Holidays
                .Where(x=>x.RequesterId == _userManager.GetUserId(User));
            return View(await userRequests.ToListAsync());
        }

        [Authorize(Roles = "CEO, Team Lead")]
        public async Task<IActionResult> Pending()
        {
            AppUser user = await _userManager.GetUserAsync(User);
            List<Holiday> requests = new List<Holiday>();
            if (await _userManager.IsInRoleAsync(user, "Team Lead"))
            {
                requests = await _db.Holidays
                    .Include(x => x.Requester)
                    .Where(x => x.Requester.TeamId == user.TeamLedId)
                    .Where(x => x.Requester.TeamLedId == null)
                    .Where(x => x.RequesterId != user.Id)
                    .ToListAsync();
            }
            else if(await _userManager.IsInRoleAsync(user, "CEO"))
            {
                requests = await _db.Holidays
                    .Include(x => x.Requester)
                    .ToListAsync();
            }
            return View(requests);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _db.Holidays == null)
            {
                return NotFound();
            }

            var holiday = await _db.Holidays
                .Include(h => h.Requester)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (holiday == null)
            {
                return NotFound();
            }

            return View(holiday);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Holiday holiday)
        {
            holiday.RequesterId = _userManager.GetUserId(User);
            holiday.DateOfRequest = DateTime.Today;
            try
            {
                _db.Add(holiday);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch {
                return View(holiday);
            }   
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var holiday = await _db.Holidays.FindAsync(id);
            if (holiday == null)
            {
                return NotFound();
            }
            return View(holiday);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Holiday holiday)
        {
            if (id != holiday.Id)
            {
                return NotFound();
            }
            if (holiday.RequesterId != _userManager.GetUserId(User))
            {
                return Forbid();
            }
            try
            {
                _db.Update(holiday);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            catch (DbUpdateConcurrencyException)
            {
                return View(holiday);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var holiday = await _db.Holidays.FindAsync(id);
            if (holiday != null)
            {
                if (await HasAccessToDelete(holiday))
                {
                    _db.Holidays.Remove(holiday);
                }
                else
                {
                    return Forbid();
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        [Authorize(Roles = "CEO, Team Lead")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ApproveRequest(int id)
        {
            var holiday = await _db.Holidays.FindAsync(id);
            if (holiday != null)
            {
                if (await HasAccessToApprove(holiday))
                {
                    holiday.IsApproved = true;
                }
                else
                {
                    return Forbid();
                }
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            else
            {
                return NotFound();
            }
        }

        private async Task<bool> HasAccessToDelete(Holiday holiday)
        {
            AppUser user = await _userManager.GetUserAsync(User);
            if (holiday.IsApproved)
            {
                return false;
            }
            if (holiday.RequesterId == user.Id || await _userManager.IsInRoleAsync(user, "CEO"))
            {
                return true;
            }
            return await IsLeaderOfRequesterTeam(holiday, user);
        }

        private async Task<bool> HasAccessToApprove(Holiday holiday)
        {
            AppUser user = await _userManager.GetUserAsync(User);
            if (holiday.IsApproved)
            {
                return false;
            }
            if (await _userManager.IsInRoleAsync(user, "CEO"))
            {
                return true;
            }
            return await IsLeaderOfRequesterTeam(holiday, user);
        }

        private async Task<bool> IsLeaderOfRequesterTeam(Holiday holiday, AppUser user)
        {;
            if (await _userManager.IsInRoleAsync(user, "Team Lead"))
            {
                AppUser requester = await _userManager.FindByIdAsync(holiday.RequesterId);
                if (requester.TeamId == user.TeamId)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

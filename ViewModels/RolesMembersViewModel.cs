using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class RolesMembersViewModel
    {
        public string RoleName { get; set; }
        public List<AppUser> Members { get; set; }
    }
}

using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class EmployeeDetailsViewModel
    {
        public AppUser User { get; set; }
        public List<Team> Teams { get; set; }
        public int TeamId { get; set; }
        public string UserId { get; set; }
    }
}

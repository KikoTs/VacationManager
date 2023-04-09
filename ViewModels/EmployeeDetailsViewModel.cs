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
    public class ManageUserRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public IList<string> UserRoles { get; set; }
        public IList<string> AllRoles { get; set; }
        public string[] SelectedRoles { get; set; }
    }
}

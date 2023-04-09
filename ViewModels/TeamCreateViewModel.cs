using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class TeamCreateViewModel
    {
        public Team TeamToCreate { get; set; }
        public List<AppUser> UsersWithNoTeam { get; set; }
    }
}

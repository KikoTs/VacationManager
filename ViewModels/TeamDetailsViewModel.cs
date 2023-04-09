using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class TeamDetailsViewModel
    {
        public Team TeamData { get; set; }
        public List<AppUser> UsersNotInTeam { get; set; }
        public string UserToAddId { get; set; }
        public int TeamId { get; set; }
    }
}

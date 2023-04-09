using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class TeamEditViewModel
    {
        public List<AppUser> UserNotLeading { get; set; }
        public Team Team { get; set; }
        public string OldTeamLeadId { get; set; }
    }
}

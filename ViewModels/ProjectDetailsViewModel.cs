using VacationManager.Models;

namespace VacationManager.ViewModels
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }
        public List<Team> TeamsWithoutProject { get; set; }
        public int TeamToAddId { get; set; }
        public int ProjectId { get; set; }
    }
}

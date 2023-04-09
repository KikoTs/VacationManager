using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationManager.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Maximum 70 characters, minimum 3")]
        public string Name { get; set; }

        [StringLength(200, MinimumLength = 3, ErrorMessage = "Maximum 200 characters, minimum 3")]
        public string Description { get; set; }

        public IEnumerable<Team> TeamsAtWork { get; set; }
    }
}

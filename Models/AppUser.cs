using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationManager.Models
{
    public class AppUser : IdentityUser
    {
        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Maximum 70 characters, minimum 3")]
        [DisplayName("First name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(70, MinimumLength = 3, ErrorMessage = "Maximum 70 characters, minimum 3")]
        [DisplayName("Last name")]
        public string LastName { get; set; }

        [DisplayName("Team")]
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        [DisplayName("Team led")]
        public int? TeamLedId { get; set; }
        public Team TeamLed { get; set; }

        public IEnumerable<Holiday> RequestedHolidays { get; set; }

        [DisplayName("Main role")]
        [NotMapped]
        public string MainRole { get; set; }
    }
}

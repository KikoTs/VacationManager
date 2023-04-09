using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using VacationManager.Enums;
using System.ComponentModel;

namespace VacationManager.Models
{
    public class Holiday
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("Start date")]
        [Column(TypeName = "date")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Required")]
        [DisplayName("End date")]
        [Column(TypeName = "date")]
        public DateTime EndDate { get; set; }

        [Required]
        [DisplayName("Date of request")]
        [Column(TypeName = "date")]
        public DateTime DateOfRequest { get; set; }

        [Required]
        [DisplayName("Half day holiday")]
        public bool IsHalfDay { get; set; }

        [Required]
        [DisplayName("Approved")]
        public bool IsApproved { get;set; }

        public HolidayType Type { get; set; }

        [DisplayName("Patient note")]
        public string? PatientNote { get; set; }

        [Required]
        [DisplayName("Requester")]
        public string RequesterId { get; set; }

        public AppUser Requester { get; set; }
    }
}

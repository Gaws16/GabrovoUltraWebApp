using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("FirstName of the runner")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("LastName of the runner")]
        public string LastName { get; set; } = null!;

        [Comment("Age of the runner")]
        [Required]
        public int Age { get; set; }
        [Comment("Gender of the runner")]
        [Required]
        public Gender Gender { get; set; }

        [MaxLength(TeamMaxLength)]
        [Comment("Name of the team")]
        public string? Team { get; set; }

        [MaxLength(CountryMaxLength)]
        [Comment("Country of origin")]
        public string Country { get; set; } = null!;
        [MaxLength(CityMaxLength)]
        [Comment("City of origin")]
        public string City { get; set; } = null!;

        public int? RegistrationId { get; set; }
        [ForeignKey(nameof(RegistrationId))]
        public Registration Registration { get; set; } = null!;
    }
}

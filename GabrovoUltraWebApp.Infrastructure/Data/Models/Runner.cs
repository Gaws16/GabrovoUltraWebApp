using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Runner
    {
        [Key]
        [Comment("PrimaryKey")]
        public int Id { get; set; }
        [Comment("ForeignKey to AspNetUsers table")]
        public string? UserId { get; set; } 

        [Required]
        public virtual IdentityUser User { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("FirstName of the runner")]
        public string FirstName { get; set; } = null!;
        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("LastName of the runner")]
        public string LastName { get; set; } = null!;
        [Comment("Email of the runner/user")]
        [Required]
        public string Email { get; set; } = null!;

        [Comment("Age of the runner")]
        [Required]
        public int Age { get; set; }
        [Comment("Gender of the runner")]
        [Required]
        public Gender Gender { get; set; }

        [MaxLength(TeamMaxLength)]
        [Comment("Name of the team")]
        public string? Team { get; set; }

        [Required]
        [MaxLength(StartingNumberMaxLength)]
        [Comment("Starting number of the runner")]
        public string StartingNumber { get; set; } = null!;

       
    }
}
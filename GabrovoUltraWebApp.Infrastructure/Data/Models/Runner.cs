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

        [Required]
        public string UserId { get; set; } = null!;

        [Required]
        public virtual IdentityUser User { get; set; } = null!;

        [Required]
        [MaxLength(NameMaxLength)]
        [Comment("Name of the runner")]
        public string Name { get; set; } = null!;

        [MaxLength(TeamMaxLength)]
        [Comment("Name of the team")]
        public string? Team { get; set; }

        [Required]
        [MaxLength(StartingNumberMaxLength)]
        [Comment("Starting number of the runner")]
        public string StartingNumber { get; set; } = null!;

        [Required]
        [MaxLength(CategoryMaxLength)]
        [Comment("Category of the runner")]
        public string Category { get; set; } = null!;

        [Required]
        public virtual ICollection<RaceRunner> RacesRunners { get; set; } = new HashSet<RaceRunner>();
    }
}
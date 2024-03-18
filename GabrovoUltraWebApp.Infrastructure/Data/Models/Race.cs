using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Race
    {
        [Key]
        [Comment("PrimaryKey")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Name of the race")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        [Comment("Description of the race")]
        public string Description { get; set; } = null!;

        [Required]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(LocationMaxLength)]
        [Comment("Location of the race")]
        public string Location { get; set; } = null!;
        [Comment("Collection of all distances suported by the race")]
        [Required]
        public virtual ICollection<Distance> Distances { get; set; } = new HashSet<Distance>();
        [Comment("Collection of runners from all distances")]
        [Required]

        public virtual ICollection<RaceRunner> RacesRunners { get; set; } = new HashSet<RaceRunner>();


    }
}

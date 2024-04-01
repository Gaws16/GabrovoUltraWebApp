using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Distance;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Distance
    {
        [Key]
        [Comment("PrimaryKey")]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        [Comment("Name of the distance")]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        [Comment("Description of the distance")]
        public string Description { get; set; } = null!;

        [Required]
        [Comment("Start time of the distance")]
        [StringLength(5)]
        public string StartTime { get; set; } = null!;

        [Required]
        [Comment("Length of the distance in kilometers")]
        public double Length { get; set; }

        [Required]
        [Comment("Elevation gain of the distance in meters")]
        public double ElevationGain { get; set; }
     
        public int RaceId { get; set; }
        [ForeignKey(nameof(RaceId))]
        [Required]
        public virtual Race Race { get; set; } = null!;

        public int RegistrationId { get; set; }

        public Registration Registration { get; set; }
    }
}
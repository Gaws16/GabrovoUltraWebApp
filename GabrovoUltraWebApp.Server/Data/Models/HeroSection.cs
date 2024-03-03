using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Server.Common.DataValidationConstants.HeroSection;
namespace GabrovoUltraWebApp.Server.Data.Models
{
    public class HeroSection
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;
    }
}

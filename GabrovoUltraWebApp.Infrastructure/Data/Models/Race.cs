using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public string Description { get; set; } = null!;

        [Required]
        public string StartPoint { get; set; } = null!;
        [Required]
        public string EndPoint { get; set; } = null!;


    }
}

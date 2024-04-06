using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Category;
namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public int MinAge { get; set; }

        [Required]
        public int MaxAge { get; set; }

        [Required]
        public int RaceId { get; set; }
        [ForeignKey(nameof(RaceId))]
        public Race Race { get; set; } = null!;

        
    }
}

using System.ComponentModel.DataAnnotations;
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
    }
}

using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.HeroSection;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;

namespace GabrovoUltraWebApp.Infrastructure.Models.ImportDTO
{
    public class CreateHeroSectionRequestDTO
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(DescriptionMaxLength, MinimumLength = DescriptionMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Description { get; set; } = null!;
        [Required]
        [RegularExpression(ValidateImageUrlRegex,
                       ErrorMessage = InvalidImageUrlErrorMessage)]
        public string ImageUrl { get; set; } = null!;
    }
}

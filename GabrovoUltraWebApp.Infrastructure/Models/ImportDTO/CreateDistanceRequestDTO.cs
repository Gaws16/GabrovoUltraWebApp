using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Distance;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.ImportDTO
{
    public class CreateDistanceRequestDTO
    {
        [StringLength(NameMaxLength,
            MinimumLength = NameMinLength,
            ErrorMessage =LengthErrorMessage )]
        [Required]
        public string Name { get; set; } = null!;

        [StringLength(DescriptionMaxLength,
           MinimumLength = DescriptionMinLength,
           ErrorMessage = LengthErrorMessage)]
        [Required]
        public string Description { get; set; } = null!;

        [StringLength(5,
            MinimumLength = 5,
            ErrorMessage = LengthErrorMessage)]
        [Required]
        [RegularExpression(StartTimeRegex,
                       ErrorMessage = StartTimeErrorMessage)]
        public string StartTime { get; set; } = null!;
        [Required
        ,Range(LengthMinValue,LengthMaxValue)]
        public int Length { get; set; }

        [Required]
        public int RaceId { get; set; }

    }
}

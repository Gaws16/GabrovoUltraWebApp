using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class CreateOrUpdateRaceRequestDTO
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
        [StringLength(LocationMaxLength, MinimumLength = LocationMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Location { get; set; } = null!;

        //TODO validate date
        [Required]
        public string Date { get; set; } = null!;
    }
}

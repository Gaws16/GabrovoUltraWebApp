using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class UpdateUserRequestDTO
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string LastName { get; set; } = null!;
        [Required]
        [Range(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }
        

        [StringLength(TeamMaxLength, MinimumLength = TeamMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string? Team { get; set; }
        [StringLength(CityMaxLength, MinimumLength = CityMinLength,
                       ErrorMessage = LengthErrorMessage)]
        [Required]
        public string City { get; set; } = null!;
        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength,
                                  ErrorMessage = LengthErrorMessage)]
        [Required]
        public string Country { get; set; } = null!;
    }
}

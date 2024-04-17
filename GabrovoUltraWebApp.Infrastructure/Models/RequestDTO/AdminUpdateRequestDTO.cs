using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
using static global::GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
using static global::GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Result;
namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class AdminUpdateRequestDTO
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
        [Required]
        [StringLength(TeamMaxLength, MinimumLength = TeamMinLength,
                       ErrorMessage = LengthErrorMessage)]
        public string? Team { get; set; }
        [Required]
        [StringLength(CityMaxLength, MinimumLength = CityMinLength,
                                  ErrorMessage = LengthErrorMessage)]
        public string City { get; set; } = null!;
        [Required]
        [StringLength(CountryMaxLength, MinimumLength = CountryMinLength,
                                             ErrorMessage = LengthErrorMessage)]
        public string Country { get; set; } = null!;
      
        [Required]
        [EnumDataType(typeof(Gender))]
        public string Gender { get; set; } = null!;
        [Required]
        [StringLength(StartingNumberMaxLength, MinimumLength = StartingNumberMinLength,
                                                        ErrorMessage = LengthErrorMessage)]
        public string StartingNumber { get; set; } = null!;
        public int RaceId { get; set; } 

        [Required]
        [RegularExpression(ResultRegex,ErrorMessage =ResultErrorMessage)]
        public string Result { get; set; } = null!;
        public int DistanceId { get; set; } 



    }
}

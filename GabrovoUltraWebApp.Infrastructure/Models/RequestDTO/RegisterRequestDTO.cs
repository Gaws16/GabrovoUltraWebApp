using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [StringLength(UsernameMaxLength, MinimumLength = UsernameMinLength,
                       ErrorMessage = LengthErrorMessage)]
        public string Username { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        [MinLength(PasswordMinLength,
                     ErrorMessage = PasswordErrorMessage)]
        public string Password { get; set; } = null!;

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        [RegularExpression(NameOnlyLettersRegex, ErrorMessage = NameOnlyLettersErrorMessage)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        [RegularExpression(NameOnlyLettersRegex, ErrorMessage = NameOnlyLettersErrorMessage)]
        public string LastName { get; set; } = null!;
        [Required]
        [Range(AgeMinValue, AgeMaxValue)]
        public int Age { get; set; }
        [Required]
        [EnumDataType(typeof(Gender))]
        public string Gender { get; set; } = null!;

        [StringLength(TeamMaxLength, MinimumLength = TeamMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string? Team { get; set; }
        [Required]
        public string[] Roles { get; set; }
    }
}

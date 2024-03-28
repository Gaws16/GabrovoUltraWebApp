using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Runner;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;

namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class CreateRunnerRequestDTO
    {
        [Required]
        [StringLength(NameMaxLength, MinimumLength =NameMinLength,
            ErrorMessage =LengthErrorMessage)]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(NameMaxLength,MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string LastName { get; set; } = null!;
        [Required]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Email { get; set; } = null!;
        [Required]
        [Range(AgeMinValue,AgeMaxValue)]
        public int Age { get; set; }
        [Required]
        public string Gender { get; set; } = null!;

        [StringLength(TeamMaxLength, MinimumLength = TeamMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string? Team { get; set; }

        [Required]
        [StringLength(StartingNumberMaxLength, MinimumLength = StartingNumberMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string StartingNumber { get; set; } = null!;

    }
}

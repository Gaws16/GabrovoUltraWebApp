using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Registration;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class UpdateRegistrationRequestDTO
    {
        [Key]
        [Comment("Registration Id")]
        public int RegistrationId { get; set; }
        [Required]
        [Comment("Foreign key to ASPUsers")]
        public string UserId { get; set; } = null!;
       

        [Required]
        public int RaceId { get; set; }


        [Required]
        public int DistanceId { get; set; }
        

        public int? ResultId { get; set; }


        [Required]
        public bool IsPaymentConfirmed { get; set; }

        [Required]
        [StringLength(StartingNumberMaxLength,MinimumLength = StartingNumberMinLength,
            ErrorMessage =LengthErrorMessage)]
        public string StartingNumber { get; set; } = null!;
    }
}

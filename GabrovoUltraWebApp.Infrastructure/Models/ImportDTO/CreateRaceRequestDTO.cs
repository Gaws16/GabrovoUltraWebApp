using System.ComponentModel.DataAnnotations;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;
using static GabrovoUltraWebApp.Infrastructure.Common.ErrorMessages;
namespace GabrovoUltraWebApp.Infrastructure.Models.ImportDTO
{
    public class CreateRaceRequestDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(NameMaxLength, MinimumLength = NameMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Name { get; set; } = null!;
        [Required]
        [StringLength(LocationMaxLength, MinimumLength = LocationMinLength,
            ErrorMessage = LengthErrorMessage)]
        public string Location { get; set; } = null!;

        //TODO validate date
        public DateTime Date { get; set; }
    }
}

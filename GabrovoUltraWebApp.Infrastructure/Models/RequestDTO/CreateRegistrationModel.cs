using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class CreateRegistrationModel
    {
        public Distance Distance { get; set; }

        public ApplicationUser User { get; set; }

        public Race Race { get; set; }
    }
}

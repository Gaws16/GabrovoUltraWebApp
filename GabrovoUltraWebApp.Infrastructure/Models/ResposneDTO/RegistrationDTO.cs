using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class RegistrationDTO
    {
        public int RegistrationId { get; set; }
        public string UserId { get; set; } = null!;
        public int RaceId { get; set; }
        public int DistanceId { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int ResultId { get; set; }
        public int CategoryId { get; set; }
        public bool IsPaymentConfirmed { get; set; }
        public string StartingNumber { get; set; } = null!;
    }
}

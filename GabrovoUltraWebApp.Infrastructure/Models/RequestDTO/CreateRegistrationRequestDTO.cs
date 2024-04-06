using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class CreateRegistrationRequestDTO
    {
        public int DistanceId { get; set; }
        public string StartingNumber { get; set; } = null!;
    }
}

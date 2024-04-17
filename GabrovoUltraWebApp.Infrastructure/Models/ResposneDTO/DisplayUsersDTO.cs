using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class DisplayUsersDTO
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Age { get; set; }
        public string Team { get; set; } = null!;
        public string Gender { get; set; }
        public string StartingNumber { get; set; } = null!;
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Race { get; set; } = null!;
        public string Distance { get; set; } = null!;
        public string Result { get; set; }
    }
}

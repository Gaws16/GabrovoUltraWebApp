using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class TokenResponseDTO
    {
        public string JwtToken { get; set; } = null!;
        public DateTime ExpirationTime { get; set; }

        public string? FirstName { get; set; }

        public string? Role { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class EditRunnerResponseDTO
    {
        public string Id { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Age { get; set; }
        public string City { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Team { get; set; } = null!;
    }
}

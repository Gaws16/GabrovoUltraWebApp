using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Models.DTO
{
    public class DistanceDTO
    {
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string StartTime { get; set; } = null!;

        public int Length { get; set; }

    }
        
}

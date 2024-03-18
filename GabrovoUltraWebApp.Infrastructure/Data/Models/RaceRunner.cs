using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class RaceRunner
    {
        [Required]
        public int RaceId { get; set; }
        [ForeignKey(nameof(RaceId))]
        public virtual Race Race { get; set; } = null!;

        [Required]
        public int RunnerId { get; set; }
        [ForeignKey(nameof(RunnerId))]
        public virtual Runner Runner { get; set; } = null!;
    }
}

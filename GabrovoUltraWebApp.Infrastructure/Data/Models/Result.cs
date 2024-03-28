using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RaceId { get; set; }
        [ForeignKey(nameof(RaceId))]
        public Race Race { get; set; }
        [Required]
        public int DistanceId { get; set; }
        [ForeignKey(nameof(DistanceId))]
        public virtual Distance Distance { get; set; } = null!;
        [Required]
        public int RunnerId { get; set; }
        [ForeignKey(nameof(RunnerId))]
        public virtual Runner Runner { get; set; } = null!;
        public TimeSpan Time { get; set; }
        
    }
}

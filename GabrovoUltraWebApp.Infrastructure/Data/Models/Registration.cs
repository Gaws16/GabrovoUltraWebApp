using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Registration
    {
        [Key]
        [Comment("Registration Id")]
        public int RegistrationId { get; set; }
        [Required]
        [Comment("Foreign key to ASPUsers")]
        public string UserId { get; set; } = null!;
        public ApplicationUser User { get; set; } = null!;

        [Required]
        public int RaceId { get; set; }
        
        public Race Race { get; set; }

        [Required]
        public int DistanceId { get; set; }
        
        public virtual Distance Distance { get; set; } = null!;
        [Required]
        public DateTime RegistrationDate { get; set; }
        [Required]
        public int ResultId { get; set; }
       
        public virtual Result Result { get; set; } = null!;
        [Required]
        public int CategoryId { get; set; }
        
        public virtual Category Category { get; set; } = null!;
        [Required]
        public bool IsPaymentConfirmed { get; set; }
    }
}

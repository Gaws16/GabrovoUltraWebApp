using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GabrovoUltraWebApp.Infrastructure.Data.Models
{
    public class Result
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RegistrationId { get; set; }
        [ForeignKey("RegistrationId")]
        public Registration Registration { get; set; }
        public TimeSpan? FinishTme { get; set; }
        public int OverallRank { get; set; }
        public int CategoryRank { get; set; }

   
        
    }
}

using System.ComponentModel.DataAnnotations;

namespace GabrovoUltraWebApp.Infrastructure.Models.RequestDTO
{
    public class RegisterRequestDTO
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Username { get; set; } = null!;
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; } = null!;
        public string[] Roles { get; set; }
    }
}

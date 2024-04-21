namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class TokenResponseDTO
    {
        public string JwtToken { get; set; } = null!;
        public DateTime ExpirationTime { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }

        public string[] Roles { get; set; }
    }
}

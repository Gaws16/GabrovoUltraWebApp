namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class RegistrationDTO
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public int RaceId { get; set; }
        public int DistanceId { get; set; }
        public string RegistrationDate { get; set; } = null!;
        public bool IsPaymentConfirmed { get; set; }
        public string StartingNumber { get; set; } = null!;
    }
}

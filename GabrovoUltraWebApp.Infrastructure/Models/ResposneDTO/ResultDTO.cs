namespace GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO
{
    public class ResultDTO
    {
        public int Id { get; set; }
        public string RegistrationUserFirstName { get; set; }
        public string RegistrationUserLastName { get; set; }

        public TimeSpan? Time { get; set; }
    }
}

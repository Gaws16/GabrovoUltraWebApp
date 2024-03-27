namespace GabrovoUltraWebApp.Infrastructure.Models.ResponseDTO
{
    public class RaceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;
        public string Location { get; set; } = null!;
        public string Date { get; set; } = null!;
    }
}

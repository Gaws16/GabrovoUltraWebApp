namespace GabrovoUltraWebApp.Infrastructure.Models.ResponseDTO
{
    public class DistanceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string StartTime { get; set; } = null!;

        public int Length { get; set; }

        public string ImagePath { get; set; } = null!;

        public double ElevationGain { get; set; }

        public int RaceId { get; set;}

    }
        
}

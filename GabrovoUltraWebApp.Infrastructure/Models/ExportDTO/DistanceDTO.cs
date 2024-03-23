﻿namespace GabrovoUltraWebApp.Infrastructure.Models.DTO
{
    public class DistanceDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string StartTime { get; set; } = null!;

        public int Length { get; set; }

    }
        
}

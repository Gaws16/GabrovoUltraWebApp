﻿namespace GabrovoUltraWebApp.Infrastructure.Models.DTO
{
    public class HeroSectionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } =null!;

        public string Description { get; set; } = null!;

        public string ImageUrl { get; set; } = null!;
    }
}

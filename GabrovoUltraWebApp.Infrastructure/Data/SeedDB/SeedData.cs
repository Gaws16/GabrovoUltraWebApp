using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public ICollection<HeroSection> HeroSection { get; set; } = new HashSet<HeroSection>();

        public SeedData()
        {
            SeedHeroSection();
        }
        private void SeedHeroSection()
        {
            HeroSection.Add( new HeroSection
            {
                Id = 1,
                Name = "Vitite skali view",
                Description = "nqkakav si tam lorem ipsum",
                ImageUrl = "/public/VititeSkaliView.jpg"
            });   
            HeroSection.Add( new HeroSection
            {
                Id = 2,
                Name = "Integral view 2",
                Description = "gotina magla koqto ne se vijda na snimkata",
                ImageUrl = "/public/Integra2.jpg"
            });   
            HeroSection.Add( new HeroSection
            {
                Id = 3,
                Name = "Integral",
                Description = "Super qkiq deskription!",
                ImageUrl = "/public/Integral.jpg"
            });   
            HeroSection.Add( new HeroSection
            {
                Id = 4,
                Name = "Samo skali",
                Description = "Super qkiq motivacionen citat",
                ImageUrl = "/public/Skali.jpg"
            });   
            HeroSection.Add( new HeroSection
            {
                Id = 5,
                Name = "Gradishte",
                Description = "Malko kofti snimka",
                ImageUrl = "/public/GradishteSunSet.jpg"
            });   
            HeroSection.Add( new HeroSection
            {
                Id = 6,
                Name = "Ispolin",
                Description = "snimano na greshnata strana",
                ImageUrl = "/public/IspolinSunset.jpg"
            });   

        }
    }
}
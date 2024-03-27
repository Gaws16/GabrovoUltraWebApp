using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public ICollection<HeroSection> HeroSection { get; set; } = new HashSet<HeroSection>();
        public ICollection<IdentityRole> Roles { get; set; } = new List<IdentityRole>();

        public SeedData()
        {
            SeedHeroSection();
            SeedRoles();
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
        private void SeedRoles()
        {
           
            var readerRoleId = "80908387-bbd3-404f-a019-90f77d87adf8";
            var writerRoleId = "4be6dd46-69ab-4c08-a820-bcb4bb3d2922";


            Roles.Add(new IdentityRole
            {
                Id = readerRoleId,
                ConcurrencyStamp = readerRoleId,
                Name = "Reader",
                NormalizedName = "Reader".ToUpper()
            });
               Roles.Add( new IdentityRole
                {
                    Id = writerRoleId,
                    ConcurrencyStamp = writerRoleId,
                    Name = "Writer",
                    NormalizedName = "Writer".ToUpper()
                }
            );
        }
    }
}
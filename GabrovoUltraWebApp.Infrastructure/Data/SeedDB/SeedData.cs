using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public ICollection<HeroSection> HeroSection { get; set; } = new HashSet<HeroSection>();
        public ICollection<IdentityRole> Roles { get; set; } = new List<IdentityRole>();
        public ICollection<Runner> Runners { get; set; } = new List<Runner>();
        public SeedData()
        {
            SeedHeroSection();
            SeedRoles();
            SeedRunners();
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
        
        private void SeedRunners()
        {
            Runners.Add(new Runner
            {
                Id = 1,
                UserId = null,
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "iva@gmail.com",
                Age = 25,
                Team = "Team Rocket",
                StartingNumber = "0001"
            });
            Runners.Add(new Runner
            {
                Id = 2,
                UserId = null,
                FirstName = "Petar",
                LastName = "Petrov",
                Email = "petar@gmai.com",
                Age = 30,
                Team = "Team Rocket",
                StartingNumber = "0002"
            });
            Runners.Add(new Runner
            {
                Id = 3,
                UserId = null,
                FirstName = "Georgi",
                LastName = "Georgiev",
                Email = "georgi@gmail.com",
                Age = 35,
                Team = "Svinski Trast",
            });
            Runners.Add(new Runner
            {
                Id = 4,
                UserId = null,
                FirstName = "Stoyan",
                LastName = "Stoyanov",
                Email = "stoyan@gmail.com",
                Age = 40,
                Team = "Svinski Trast",
                StartingNumber = "0003"
            });
            Runners.Add(new Runner
            {
                Id = 5,
                UserId = null,
                FirstName = "Ivaylo",
                LastName = "Ivaylov",
                Email = "ivaylo@gmail.com",
                Age = 45,
                Team = "Svinski Trast",
                StartingNumber = "0004"
            });
            Runners.Add(new Runner
            {
                Id = 6,
                UserId = null,
                FirstName = "Angel",
                LastName = "Ivanov",
                Email = "angel@gmailcom",
                Age = 50,
                Team = "Buhal v Goratat",
                StartingNumber = "0005"
            });
            Runners.Add(new Runner
            {
                Id = 7,
                UserId = null,
                FirstName = "Boris",
                LastName = "Angelov",
                Email = "boris@gmail.com",
                Age = 55,
                Team = "Team Rocket",
                StartingNumber = "0006"
            });
            Runners.Add(new Runner
            {
                Id = 8,
                UserId = null,
                FirstName = "Vasil",
                LastName = "Vasilev",
                Email = "vasko@yahoo.com",
                Age = 60,
                Team = "Besni Tigri",
            });
            Runners.Add(new Runner
            {
                Id = 9,
                UserId = null,
                FirstName = "Krasimir",
                LastName = "Krasimirov",
                Email = "kras@yahoo.com",
                Age = 65,
                Team = "Besni Tigri",
            });
            Runners.Add(new Runner
            {
                Id = 10,
                UserId = null,
                FirstName = "Hristo",
                LastName = "Krasimirov",
                Email = "icho@abv.bg",
                Age = 70,
                Team = "SoftUni",
            });
           

        }
    }
}
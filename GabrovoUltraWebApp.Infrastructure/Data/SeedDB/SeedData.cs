using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public ICollection<HeroSection> HeroSection { get; set; } = new HashSet<HeroSection>();
        public ICollection<IdentityRole> Roles { get; set; } = new HashSet<IdentityRole>();
        public ICollection<Race> Races { get; set; } = new HashSet<Race>();
        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
        public ICollection<Distance> Distances { get; set; } = new HashSet<Distance>();
        public SeedData()
        {
            SeedHeroSection();
            SeedRoles();
            SeedCategories();
            SeedRaces();
            SeedDistances();
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
        private void SeedDistances()
        {
            Distances.Add(new Distance
            {
                Id = 1,
                Name = "Черешката",
                Description = "75км с 4300 D+ и пълна автономност - без никакви подрекрепителни пунктве. Истинско изпитание.",
                ElevationGain = 4300,
                Length = 75,
                ImagePath = "/Components/Distances/trqnva1.jpg",
                StartTime= "06:09",
                RaceId = 1
            });Distances.Add(new Distance
            {
                Id = 2,
                Name = "Глазурата",
                Description = "Маратонски 42км с над 2500 D+ и пълна автономност - без никакви подрекрепителни пунктве. По-малкото \"мъчение\".",
                ElevationGain = 2500,
                Length = 42,
                ImagePath = "/Components/Distances/kodja-kaq.jpg",
                StartTime= "08:00",
                RaceId = 1
            });Distances.Add(new Distance
            {
                Id = 3,
                Name = "Блатът",
                Description = "30км Sky с 1950 D+ и пълна автономност - без никакви подрекрепителни пунктве. Предизвикателството.",
                ElevationGain = 1950,
                Length = 30,
                ImagePath = "/Components/Distances/tarnovo.jpg",
                StartTime= "09:30",
                RaceId = 1
            });Distances.Add(new Distance
            {
                Id = 4,
                Name = "Жилката",
                Description = "14км с 1050 D+ и пълна автономност - без никакви подрекрепителни пунктве. Напреднало ниво.",
                ElevationGain = 1050,
                Length = 14,
                ImagePath = "/Components/Distances/trqnva1.jpg",
                StartTime= "12:00",
                RaceId = 1
            });Distances.Add(new Distance
            {
                Id = 5,
                Name = "Допълнителен десерт",
                Description = "Скоростно изкачване на Телевизионната кула (Градище) 3.6км с 500 D+. Допълнително изпитание, в което всеки може да се включи.",
                ElevationGain = 50,
                Length = 5,
                ImagePath = "/Components/Distances/trqnva1.jpg",
                StartTime= "14:00",
                RaceId = 1
            });
        }
        private void SeedCategories()
        {
            Categories.Add(new Category
            {
                Id = 1,
                Name = "Юнуша",
                MaxAge = 21,
                MinAge = 16,
                RaceId = 1

            });
            Categories.Add(new Category
            {
                Id = 2,
                Name = "Младши",
                MaxAge = 35,
                MinAge = 22,
                RaceId = 1
            });
            Categories.Add(new Category
            {
                Id = 3,
                Name = "Старши",
                MinAge = 36,
                MaxAge = 49,
                RaceId = 1
            });
            Categories.Add(new Category
            {
                Id = 4,
                Name = "Ветеран",
                MaxAge = 100,
                MinAge = 50,
                RaceId = 1
            }); Categories.Add(new Category
            {
                Id = 5,
                Name = "Юнуша",
                MaxAge = 21,
                MinAge = 16,
                RaceId = 2

            });
            Categories.Add(new Category
            {
                Id = 6,
                Name = "Младши",
                MaxAge = 35,
                MinAge = 22,
                RaceId = 2
            });
            Categories.Add(new Category
            {
                Id = 7,
                Name = "Старши",
                MinAge = 36,
                MaxAge = 49,
                RaceId = 2
            });
            Categories.Add(new Category
            {
                Id = 8,
                Name = "Ветеран",
                MaxAge = 100,
                MinAge = 50,
                RaceId = 2
            });
            
        }
        private void SeedRaces()
        {
            Races.Add(new Race
            {
                Id = 1,
                Name = "Габрово Ултра 2024",
                Description = "Второ издание на невероятното трейл приключение",
                Date = new DateTime(2024, 9, 16),
                Location = "Габрово",
            });
            Races.Add(new Race
            {
                Id = 2,
                Name = "Габрово Ултра 2023",
                Description = "Първото първо по рода си трейл състезание в Габрово",
                Date = new DateTime(2023, 9, 16),
                Location = "Габрово"
            });
        }
    }
    }

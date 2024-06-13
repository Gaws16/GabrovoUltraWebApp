using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class SeedData
    {
        public ICollection<HeroSection> HeroSection { get; set; } = new HashSet<HeroSection>();
        public ICollection<IdentityRole> Roles { get; set; } = new HashSet<IdentityRole>();
        public ICollection<IdentityUserRole<string>> UsersRoles { get; set; } = new HashSet<IdentityUserRole<string>>();
        public ICollection<Race> Races { get; set; } = new HashSet<Race>();
        public ICollection<Category> Categories { get; set; } = new HashSet<Category>();
        public ICollection<Distance> Distances { get; set; } = new HashSet<Distance>();
        public ICollection<ApplicationUser> Users { get; set; } = new HashSet<ApplicationUser>();
        public ICollection<Registration> Registrations { get; set; } = new HashSet<Registration>();
        public ICollection<Result> Results { get; set; } = new HashSet<Result>();

        public SeedData()
        {
            SeedUsers();
            SeedHeroSection();
            SeedRoles();
            SeedUserRoles();
            SeedCategories();
            SeedRaces();
            SeedDistances();
            SeedRegistrations();
            SeedResults();
        }
        private void SeedHeroSection()
        {
            HeroSection.Add(new HeroSection
            {
                Id = 1,
                Name = "Vitite skali view",
                Description = "nqkakav si tam lorem ipsum",
                ImageUrl = "/VititeSkaliView.jpg"
            });
            HeroSection.Add(new HeroSection
            {
                Id = 2,
                Name = "Integral view 2",
                Description = "gotina magla koqto ne se vijda na snimkata",
                ImageUrl = "/Integra2.jpg"
            });
            HeroSection.Add(new HeroSection
            {
                Id = 3,
                Name = "Integral",
                Description = "Super qkiq deskription!",
                ImageUrl = "/Integral.jpg"
            });
            HeroSection.Add(new HeroSection
            {
                Id = 4,
                Name = "Samo skali",
                Description = "Super qkiq motivacionen citat",
                ImageUrl = "/Skali.jpg"
            });
            HeroSection.Add(new HeroSection
            {
                Id = 5,
                Name = "Gradishte",
                Description = "Malko kofti snimka",
                ImageUrl = "/GradishteSunSet.jpg"
            });
            HeroSection.Add(new HeroSection
            {
                Id = 6,
                Name = "Ispolin",
                Description = "snimano na greshnata strana",
                ImageUrl = "/IspolinSunset.jpg"
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
            Roles.Add(new IdentityRole
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
                StartTime = "06:09",
                RaceId = 1
            }); Distances.Add(new Distance
            {
                Id = 2,
                Name = "Глазурата",
                Description = "Маратонски 42км с над 2500 D+ и пълна автономност - без никакви подрекрепителни пунктве. По-малкото \"мъчение\".",
                ElevationGain = 2500,
                Length = 42,
                ImagePath = "/Components/Distances/kodja-kaq.jpg",
                StartTime = "08:00",
                RaceId = 1
            }); Distances.Add(new Distance
            {
                Id = 3,
                Name = "Блатът",
                Description = "30км Sky с 1950 D+ и пълна автономност - без никакви подрекрепителни пунктве. Предизвикателството.",
                ElevationGain = 1950,
                Length = 30,
                ImagePath = "/Components/Distances/tarnovo.jpg",
                StartTime = "09:30",
                RaceId = 1
            }); Distances.Add(new Distance
            {
                Id = 4,
                Name = "Жилката",
                Description = "14км с 1050 D+ и пълна автономност - без никакви подрекрепителни пунктве. Напреднало ниво.",
                ElevationGain = 1050,
                Length = 14,
                ImagePath = "/Components/Distances/trqnva1.jpg",
                StartTime = "12:00",
                RaceId = 1
            }); Distances.Add(new Distance
            {
                Id = 5,
                Name = "Допълнителен десерт",
                Description = "Скоростно изкачване на Телевизионната кула (Градище) 3.6км с 500 D+. Допълнително изпитание, в което всеки може да се включи.",
                ElevationGain = 50,
                Length = 5,
                ImagePath = "/Components/Distances/trqnva1.jpg",
                StartTime = "14:00",
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

        private void SeedUserRoles()
        {
            var readerRoleId = "80908387-bbd3-404f-a019-90f77d87adf8";
            var writerRoleId = "4be6dd46-69ab-4c08-a820-bcb4bb3d2922";
            UsersRoles.Add(new IdentityUserRole<string>
            {
                RoleId = readerRoleId,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36"
            });
            UsersRoles.Add(new IdentityUserRole<string>
            {
                RoleId = readerRoleId,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37"
            });
            UsersRoles.Add(new IdentityUserRole<string>
            {
                RoleId = writerRoleId,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40"
            });
        }
        private void SeedUsers()
        {

            var hasher = new PasswordHasher<ApplicationUser>();
            var pesho = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                Email = "pesho@gabrovoultra.bg",
                UserName = "pesho@gabrovoultra.bg",
                NormalizedEmail = "PESHO@GABROVOULTRA.BG",
                FirstName = "Pesho",
                LastName = "Peshov",
                NormalizedUserName = "PESHO@GABROVOULTRA.BG",
                City = "Gabrovo",
                Country = "Bulgaria",
                LockoutEnabled = false,
                RegistrationId = 12,


            };
            pesho.PasswordHash = hasher.HashPassword(pesho, "D01parola");
            Users.Add(pesho);

            var sasho = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                Email = "sasho@gabrovoultra.bg",
                UserName = "sasho@gabrovoultra.bg",
                NormalizedEmail = "SASHO@GABROVOULTRA>BG",
                FirstName = "Sasho",
                LastName = "Sashov",
                NormalizedUserName = "SASHO@GABROVOULTRA>BG",
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 13,
            };
            sasho.PasswordHash = hasher.HashPassword(sasho, "D01parola");
            Users.Add(sasho);
            var tosho = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb932fa1f37",
                Email = "tosho@gabrovoultra.bg",
                UserName = "tosho@gabrovoultra.bg",
                NormalizedEmail = "TOSHO@GABROVOULTRA>BG",
                FirstName = "Tosho",
                LastName = "Toshev",
                NormalizedUserName = "TOSHO@GABROVOULTRA>BG",
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 14,
            };
            tosho.PasswordHash = hasher.HashPassword(sasho, "D01parola");
            Users.Add(sasho);

            var dimitrichko = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38",
                Email = "dimitrichko@gabrovoultra.bg",
                UserName = "dimitrichko@gabrovoultra.bg",
                NormalizedEmail = "dimitrichko@gabrovoultra.bg".ToUpper(),
                FirstName = "Dimitrichko",
                LastName = "Dimitrichkov",
                NormalizedUserName = "dimitrichko@gabrovoultra.bg".ToUpper(),
                City = "Dimitrovgrad",
                Country = "Bulgaria",
                RegistrationId = 15,
            };
            dimitrichko.PasswordHash = hasher.HashPassword(dimitrichko, "D01parola");
            Users.Add(dimitrichko);

            var filip = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39",
                Email = "filip@gabrovoultra.bg",
                UserName = "filip@gabrovoultra.bg",
                NormalizedEmail = "filip@gabrovoultra.bg".ToUpper(),
                FirstName = "Filip",
                LastName = "Filipov",
                NormalizedUserName = "filip@gabrovoultra.bg".ToUpper(),
                City = "Veliko Tarnovo",
                Country = "Bulgaria",
                RegistrationId = 16,
            };
            filip.PasswordHash = hasher.HashPassword(filip, "D01parola");
            Users.Add(filip);

            var admin = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f40",
                Email = "admin@gabrovoultra.bg",
                UserName = "admin@gabrovoultra.bg",
                NormalizedEmail = "admin@gabrovoultra.bg".ToUpper(),
                FirstName = "Admin",
                LastName = "Adminov",
                NormalizedUserName = "admin@gabrovoultra.bg".ToUpper(),
                City = "Adminovgrad",
                Country = "Bulgaria",
            };
            admin.PasswordHash = hasher.HashPassword(admin, "D01parola");
            Users.Add(admin);
            var ivan = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f41",
                Email = "ivan@gabrovoultra.bg",
                UserName = "ivan@gabrovoultra.bg",
                NormalizedEmail = "ivan@gabrovoultra.bg".ToUpper(),
                FirstName = "Ivan",
                LastName = "Ivanov",
                NormalizedUserName = "ivan@gabrovoultra.bg".ToUpper(),
                City = "Ivanovgrad",
                Country = "Bulgaria",
                RegistrationId = 17,
            };
            ivan.PasswordHash = hasher.HashPassword(ivan, "D01parola");
            Users.Add(ivan);
            var stefan = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f42",
                Email = "stefan@gabrovoultra.bg",
                UserName = "stefan@gabrovoultra.bg",
                NormalizedEmail = "stefan@gabrovoultra.bg".ToUpper(),
                FirstName = "Stefan",
                LastName = "Stefanov",
                NormalizedUserName = "stefan@gabrovoultra.bg".ToUpper(),
                City = "Stefanovgrad",
                Country = "Bulgaria",
                RegistrationId = 18,
            };
            stefan.PasswordHash = hasher.HashPassword(stefan, "D01parola");
            Users.Add(stefan);
            var miroslav = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f43",
                Email = "miroslav@gabrovoultra.bg",
                UserName = "miroslav@gabrovoultra.bg",
                NormalizedEmail = "miroslav@gabrovoultra.bg".ToUpper(),
                FirstName = "Miroslav",
                LastName = "Miroslavov",
                NormalizedUserName = "miroslav@gabrovoultra.bg".ToUpper(),
                City = "Miroslavovgrad",
                Country = "Bulgaria",
                RegistrationId = 19,
            };
            miroslav.PasswordHash = hasher.HashPassword(miroslav, "D01parola");
            Users.Add(miroslav);
            var svetoslav = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f44",
                Email = "svetoslav@gabrovoultra.bg",
                UserName = "svetoslav@gabrovoultra.bg",
                NormalizedEmail = "svetoslav@gabrovoultra.bg".ToUpper(),
                FirstName = "Svetoslav",
                LastName = "Svetoslavov",
                NormalizedUserName = "svetoslav@gabrovoultra.bg".ToUpper(),
                City = "Svetoslavovgrad",
                Country = "Bulgaria",
                RegistrationId = 20,
            };
            svetoslav.PasswordHash = hasher.HashPassword(svetoslav, "D01parola");
            Users.Add(svetoslav);
            var mihael = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f45",
                Email = "mihael@gabrovoultra.bg",
                UserName = "mihael@gabrovoultra.bg",
                NormalizedEmail = "mihael@gabrovoultra.bg".ToUpper(),
                FirstName = "Mihael",
                LastName = "Yordanov",
                NormalizedUserName = "mihael@gabrovoultra.bg".ToUpper(),
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 21,
            };
            mihael.PasswordHash = hasher.HashPassword(mihael, "D01parola");
            Users.Add(mihael);
            var svetoslava = new ApplicationUser
            {
                Id = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f46",
                Email = "svetoslava@gabrovoultra.bg",
                UserName = "svetoslava@gabrovoultra.bg",
                NormalizedEmail = "svetoslava@gabrovoultra.bg".ToUpper(),
                FirstName = "Svetoslava",
                LastName = "Tsankova",
                NormalizedUserName = "svetoslava@gabrovoultra.bg".ToUpper(),
                City = "Gabrovo",
                Country = "Bulgaria",
                RegistrationId = 22,
            };
            svetoslava.PasswordHash = hasher.HashPassword(svetoslava, "D01parola");
            Users.Add(svetoslava);

        }

        private void SeedRegistrations()
        {
            var peshoRegistration = new Registration
            {
                Id = 12,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f36",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7505",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(peshoRegistration);
            var sashoRegistration = new Registration
            {
                Id = 13,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f37",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7505",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(sashoRegistration);
            var toshoRegistration = new Registration
            {
                Id = 14,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb932fa1f37",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7605",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(toshoRegistration);
            var dimitrichkoRegistration = new Registration
            {
                Id = 15,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f38",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7506",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(dimitrichkoRegistration);
            var filipRegistration = new Registration
            {
                Id = 16,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f39",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7507",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(filipRegistration);
            var ivanRegistration = new Registration
            {
                Id = 17,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f41",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7508",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(ivanRegistration);
            var stefanRegistration = new Registration
            {
                Id = 18,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f42",
                DistanceId = 4,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7509",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(stefanRegistration);
            var miroslavRegistration = new Registration
            {
                Id = 19,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f43",
                DistanceId = 2,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7510",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(miroslavRegistration);
            var svetoslavRegistration = new Registration
            {
                Id = 20,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f44",
                DistanceId = 3,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7511",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(svetoslavRegistration);
            var mihaelRegistration = new Registration
            {
                Id = 21,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f45",
                DistanceId = 4,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7512",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(mihaelRegistration);
            var svetoslavaRegistration = new Registration
            {
                Id = 22,
                UserId = "c6bc76d0-9af8-44ee-a228-55fb9bfa1f46",
                DistanceId = 4,
                RaceId = 1,
                RegistrationDate = DateTime.Now,
                StartingNumber = "7513",
                IsPaymentConfirmed = true,
            };
            Registrations.Add(svetoslavaRegistration);
        }

        private void SeedResults()
        {
            Results.Add(new Result
            {
                Id = 11,
                FinishTme = new TimeSpan(0, 3, 30, 0),
                RegistrationId = 12
            });
            Results.Add(new Result
            {
                Id = 12,
                FinishTme = new TimeSpan(0, 3, 45, 0),
                RegistrationId = 13
            });
            Results.Add(new Result
            {
                Id = 13,
                FinishTme = new TimeSpan(0, 3, 50, 0),
                RegistrationId = 14
            });
            Results.Add(new Result
            {
                Id = 14,
                FinishTme = new TimeSpan(0, 3, 55, 0),
                RegistrationId = 15
            });
            Results.Add(new Result
            {
                Id = 15,
                FinishTme = new TimeSpan(0, 4, 0, 0),
                RegistrationId = 16
            });
            Results.Add(new Result
            {
                Id = 16,
                FinishTme = new TimeSpan(0, 4, 5, 0),
                RegistrationId = 17
            });
            Results.Add(new Result
            {
                Id = 17,
                FinishTme = new TimeSpan(0, 4, 10, 0),
                RegistrationId = 18
            });
            Results.Add(new Result
            {
                Id = 18,
                FinishTme = new TimeSpan(0, 4, 15, 0),
                RegistrationId = 19
            });
            Results.Add(new Result
            {
                Id = 19,
                FinishTme = new TimeSpan(0, 4, 20, 0),
                RegistrationId = 20
            });
            Results.Add(new Result
            {
                Id = 20,
                FinishTme = new TimeSpan(0, 4, 25, 0),
                RegistrationId = 21
            });
            Results.Add(new Result
            {
                Id = 21,
                FinishTme = new TimeSpan(0, 4, 30, 0),
                RegistrationId = 22
            });


        }
    }
}

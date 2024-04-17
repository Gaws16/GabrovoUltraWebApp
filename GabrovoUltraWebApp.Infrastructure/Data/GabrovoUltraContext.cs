using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Data.SeedDB;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Infrastructure.Data
{
    public class GabrovoUltraContext : IdentityDbContext
    {

        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> context) : base(context)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new UsersRolesConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new RaceConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new RegistrationConfiguration());
            builder.ApplyConfiguration(new DistanceConfiguration());
            builder.ApplyConfiguration(new HeroSectionConfiguration());
            builder.ApplyConfiguration(new ResultsConfiguration());
            builder.ApplyConfiguration(new RolesConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<HeroSection> HeroSections { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Distance> Distances { get; set; }

        public DbSet<Result> Results { get; set; }

        public DbSet<Registration> Registrations { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Category> Categories { get; set; }




    }
}

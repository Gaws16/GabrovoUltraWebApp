using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Data.SeedDB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Infrastructure.Data
{
    public class GabrovoUltraContext: IdentityDbContext
    {
              
        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> context): base(context)
        {
           
        }
        

        protected override void OnModelCreating(ModelBuilder builder)
        {
            
            builder.ApplyConfiguration(new HeroSectionConfiguration());
            builder.ApplyConfiguration(new RolesConfiguration());
           // builder.ApplyConfiguration(new RunnerConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<HeroSection> HeroSections { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Runner> Runners { get; set; }

        public DbSet<Distance> Distances { get; set; }

        public DbSet<Result> Results { get; set; }




    }
}

using GabrovoUltraWebApp.Server.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Server.Data
{
    public class GabrovoUltraContext: IdentityDbContext
    {
        public DbSet<HeroSection> HeroSections { get; set; }
        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        private void SeedHeroSection(ModelBuilder builder)
        {
            builder.Entity<HeroSection>().HasData(
                               new HeroSection
                               {
                    Id = 1,
                    Name = "Vitite Skali",
                    Description = "The most extreme ultra marathon in the world!",
                    ImageUrl = "https://www.gabrovo-ultra.com/wp-content/uploads/2020/12/IMG_20201205_101153.jpg"
                }
                                          );
        }   
    }
}

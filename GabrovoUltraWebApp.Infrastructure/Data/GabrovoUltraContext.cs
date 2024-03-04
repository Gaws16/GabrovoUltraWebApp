using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Data.SeedDB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Infrastructure.Data
{
    public class GabrovoUltraContext: IdentityDbContext
    {
        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> options) : base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new HeroSectionConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<HeroSection> HeroSections { get; set; }

        
    }
}

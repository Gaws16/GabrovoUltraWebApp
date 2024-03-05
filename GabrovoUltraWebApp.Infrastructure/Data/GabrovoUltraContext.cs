using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Data.SeedDB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

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
            base.OnModelCreating(builder);
        }
        public DbSet<HeroSection> HeroSections { get; set; }

        
    }
}

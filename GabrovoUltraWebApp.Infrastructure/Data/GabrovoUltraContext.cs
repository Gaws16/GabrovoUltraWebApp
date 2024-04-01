using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Data.SeedDB;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GabrovoUltraWebApp.Infrastructure.Data
{
    public class GabrovoUltraContext : IdentityDbContext
    {

        public GabrovoUltraContext(DbContextOptions<GabrovoUltraContext> context) : base(context)
        {

        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
           builder.Entity<Registration>()
                .HasOne<Result>(r=>r.Result)
                .WithOne(r=>r.Registration)
                .HasForeignKey<Result>(r=>r.RegistrationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<Registration>()
                .HasOne<Distance>(d=>d.Distance)
                .WithOne(d=>d.Registration)
                .HasForeignKey<Distance>(d=>d.RegistrationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
        builder.Entity<Registration>()
                .HasOne<Category>(c=>c.Category)
                .WithOne(c=>c.Registration)
                .HasForeignKey<Category>(c=>c.RegistrationId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Restrict);
                
                
                
            builder.ApplyConfiguration(new HeroSectionConfiguration());
            builder.ApplyConfiguration(new RolesConfiguration());
            // builder.ApplyConfiguration(new RunnerConfiguration());
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

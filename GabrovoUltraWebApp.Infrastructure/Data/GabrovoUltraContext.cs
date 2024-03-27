﻿using GabrovoUltraWebApp.Infrastructure.Data.Models;
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
            builder.Entity<RaceRunner>
                (c => c.HasKey(pk => new { pk.RaceId, pk.RunnerId }));
            builder.ApplyConfiguration(new HeroSectionConfiguration());
            builder.ApplyConfiguration(new RolesConfiguration());
            base.OnModelCreating(builder);
        }
        public DbSet<HeroSection> HeroSections { get; set; }

        public DbSet<Race> Races { get; set; }

        public DbSet<Runner> Runners { get; set; }

        public DbSet<Distance> Distances { get; set; }




    }
}

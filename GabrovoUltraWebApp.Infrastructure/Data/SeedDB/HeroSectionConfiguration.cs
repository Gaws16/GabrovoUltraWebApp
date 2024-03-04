using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class HeroSectionConfiguration : IEntityTypeConfiguration<HeroSection>
    {
        public void Configure(EntityTypeBuilder<HeroSection> builder)
        {
            var data = new SeedData();
            builder.HasData(data.HeroSection);
        }
    }
}

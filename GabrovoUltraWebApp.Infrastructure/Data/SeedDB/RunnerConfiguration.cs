using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    public class RunnerConfiguration : IEntityTypeConfiguration<Runner>
    {
        public void Configure(EntityTypeBuilder<Runner> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Runners);
        }
    }
}

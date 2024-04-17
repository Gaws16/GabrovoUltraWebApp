using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class ResultsConfiguration : IEntityTypeConfiguration<Result>
    {
        public void Configure(EntityTypeBuilder<Result> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Results);
        }
    }
}

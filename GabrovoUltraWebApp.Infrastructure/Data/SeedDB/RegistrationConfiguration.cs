using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            builder.HasOne<Distance>(d => d.Distance)
                    .WithMany(d => d.Registrations)
                    .OnDelete(DeleteBehavior.Restrict);
          var data = new SeedData();
            builder.HasData(data.Registrations);

        }
    }
}

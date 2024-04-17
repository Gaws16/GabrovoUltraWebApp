using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GabrovoUltraWebApp.Infrastructure.Data.SeedDB
{
    internal class UsersConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var data = new SeedData();
            builder.HasData(data.Users);
        }
    }
    
}

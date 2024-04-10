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
    internal class RegistrationConfiguration : IEntityTypeConfiguration<Registration>
    {
        public void Configure(EntityTypeBuilder<Registration> builder)
        {
            //builder
            //    .HasOne<Result>(r => r.Result)
            //    .WithOne(r => r.Registration)
            //    .HasForeignKey<Result>(r => r.RegistrationId)
            //    .IsRequired()
            //    .OnDelete(DeleteBehavior.Restrict);

            builder
                    .HasOne<Distance>(d => d.Distance)
                    .WithMany(d => d.Registrations)
                    .OnDelete(DeleteBehavior.Restrict);
        }
    }
}

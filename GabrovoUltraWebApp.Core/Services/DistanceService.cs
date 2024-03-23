using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services
{
    public class DistanceService : IDistanceService
    {
        private readonly GabrovoUltraContext   context;

        public DistanceService(GabrovoUltraContext _context) 
        {
            context = _context;
        }

        public async Task<Distance> CreateAsync(Distance distance)
        {
            await context.Distances.AddAsync(distance);
            await context.SaveChangesAsync();
            return distance;
        }

        public async Task<Distance?> DeleteAsync(int id)
        {
           var expectedDistance = await context.Distances.FirstOrDefaultAsync(d=>d.Id == id);
            if (expectedDistance == null)
            {
                return null;
            }
            context.Distances.Remove(expectedDistance);
            await context.SaveChangesAsync();
            return expectedDistance;
        }

        public async Task<List<Distance>> GetAllAsync()
        => await context.Distances
            .AsNoTracking()
            .ToListAsync();

        public async Task<Distance?> GetByIdAsync(int id)
        => await context.Distances
            .FirstOrDefaultAsync(d=>d.Id==id);

        public async Task<Distance?> UpdateAsync(int id, Distance distance)
        {
            var distanceToUpdate = await context.Distances.FirstOrDefaultAsync(d=>d.Id == id);
            if (distanceToUpdate == null)
            {
                return null;
            }
            distanceToUpdate.Name = distance.Name;
            distanceToUpdate.Description = distance.Description;
            distanceToUpdate.Length = distance.Length;
            distanceToUpdate.StartTime = distance.StartTime;
            await context.SaveChangesAsync();
            return distanceToUpdate;
        }
    }
}

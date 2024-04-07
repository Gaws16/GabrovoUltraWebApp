using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Core.Services
{
    public class DistanceService : IDistanceService
    {
        
        private readonly IRepository repository;

        public DistanceService(GabrovoUltraContext _context , IRepository _repository)
        {
            
            repository = _repository;
        }

    

        public async Task<Distance?> CreateAsync(Distance distance)
        {
            await repository.AddAsync<Distance>(distance);
            await repository.SaveChangesAsync();
            return distance;
        }

        public async Task<Distance?> DeleteAsync(int id)
        {
           var expectedDistance = await repository.DeleteAsync<Distance>(id);
            if (expectedDistance == null)
            {
                return null;
            }
            
            await repository.SaveChangesAsync();
            return expectedDistance;
        }

        public async Task<List<Distance>> GetAllAsync()
        => await repository.All<Distance>().ToListAsync();

        public async Task<Distance?> GetByIdAsync(int id)
        => await repository.GetByIdAsync<Distance>(id);

        public async Task<Distance?> UpdateAsync(int id, Distance distance)
        {
            var distanceToUpdate = await repository.GetByIdAsync<Distance>(id);
            if (distanceToUpdate == null)
            {
                return null;
            }
            distanceToUpdate.Name = distance.Name;
            distanceToUpdate.Description = distance.Description;
            distanceToUpdate.Length = distance.Length;
            distanceToUpdate.StartTime = distance.StartTime;
            distanceToUpdate.ImagePath = distance.ImagePath;
            distanceToUpdate.ElevationGain = distance.ElevationGain;
            await repository.SaveChangesAsync();
            return distanceToUpdate;
        }
    }
}

using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Core.Services
{
    public class RaceService : IRaceService
    {
        private readonly IRepository repository;
        public RaceService(IRepository _repository)
        {
           repository = _repository;
        }

        public Task<Race?> CreateAsync(Race Race)
        {
            throw new NotImplementedException();
        }

        public Task<Race?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Race>> GetAllAsync()
       => await repository.All<Race>().ToListAsync();

        public Task<Race?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Race?> UpdateAsync(int id, Race Race)
        {
            throw new NotImplementedException();
        }
    }
}

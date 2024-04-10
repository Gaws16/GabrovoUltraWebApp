using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Core.Services
{
    public class ResultService : IResultService
    {
        private readonly IRepository repository;
        public ResultService(IRepository _repository)
        {
            repository = _repository;
        }
        
        public async Task<Result?> CreateAsync(Result result)
        {
            //TODO : check if the result is already in the database
            var existingResult = repository.All<Result>().FirstOrDefault(r=>r.RegistrationId==result.RegistrationId);
            if (existingResult != null)
            {
                return null;
            }
            await repository.AddAsync(result);
            await repository.SaveChangesAsync();
            return result;
        }

        public Task<Result?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Result>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            throw new NotImplementedException();
        }

        public Task<Result?> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Result?> UpdateAsync(int id, Result runner)
        {
            throw new NotImplementedException();
        }
    }
}

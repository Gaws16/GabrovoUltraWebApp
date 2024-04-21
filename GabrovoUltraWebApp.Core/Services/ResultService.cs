using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using Microsoft.EntityFrameworkCore;

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
            var existingResult = repository.All<Result>().FirstOrDefault(r=>r.RegistrationId==result.RegistrationId);
            if (existingResult != null)
            {
                return null;
            }
            await repository.AddAsync(result);
            await repository.SaveChangesAsync();
            return result;
        }

        public async Task<Result?> DeleteAsync(int id)
        {
            var resultToDelete = await repository.GetByIdAsync<Result>(id);
            if (resultToDelete == null)
            {
                return null;
            }
            await repository.DeleteAsync<Result>(id);
            await repository.SaveChangesAsync();
            return resultToDelete;
        }

        public async Task<List<ResultDTO>?> GetAllAsync(int raceId, int distanceId, string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {

            var results = await repository.All<Result>()
                                          .Include(r => r.Registration)
                                          .ThenInclude(u => u.User)
                                          .Where(r => r.Registration.RaceId == raceId && r.Registration.DistanceId == distanceId)
                                          .Select(r => new ResultDTO
                                          {
                                              RegistrationUserFirstName = r.Registration.User.FirstName,
                                              RegistrationUserLastName = r.Registration.User.LastName,
                                              Time = r.FinishTme
                                          }).ToListAsync();




            return results;
        }
    

        public async Task<Result?> GetByIdAsync(int id)
        => await repository.GetByIdAsync<Result>(id);

     
    }
}

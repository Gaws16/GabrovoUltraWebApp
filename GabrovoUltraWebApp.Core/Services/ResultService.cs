using AutoMapper;
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
        private readonly IMapper mapper;

        public ResultService(IRepository _repository, IMapper _mapper)
        {
            repository = _repository;
            mapper = _mapper;
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

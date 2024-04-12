using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants;

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

        public async Task<List<Result>> GetAllAsync(string? filterOn = null, string? filterQuery = null, string? sortBy = null, bool? isAscending = true, int pageNumber = 1, int pageSize = 1000)
        {
            var results =  repository.All<Result>();
            //if (filterOn != null && filterQuery != null)
            //{
            //    filterQuery = filterQuery.ToLower().Trim();
            //    switch (filterOn.ToLower())
            //    {
            //        case "firstname":
            //            results = results.Where(r => r.FirstName.ToLower().Contains(filterQuery));
            //            break;
            //        case "lastname":
            //            results = results.Where(r => r.LastName.ToLower().Contains(filterQuery));
            //            break;
            //        case "team":

            //            results = results.Where(r => r.Team != null && r.Team.ToLower().Contains(filterQuery));
            //            break;
            //        case "startingnumber":
            //            results = results.Where(r => r.StartingNumber.ToString().Contains(filterQuery));
            //            break;
            //        case "age":
            //            results = results.Where(r => r.Age.ToString().Contains(filterQuery));
            //            break;
            //        case "gender":
            //            results = results.Where(r => r.Gender.ToLower().Contains(filterQuery));
            //            break;
            //            //if (Enum.TryParse<Gender>(filterQuery, true, out Gender gender))
            //            //{
            //            //    results = results.Where(r => r.Gender == gender);
            //            //}
            //            //else
            //            //{
            //            //    //return empty collection if gencer is invalid
            //            //   results = results.Where(g=>false);
            //            //}

            //    }
            //}
            // Sorting
            //if (string.IsNullOrEmpty(sortBy) == false)
            //{
            //    switch (sortBy.ToLower())
            //    {
            //        case "firstname":
            //            results = isAscending == true ? results.OrderBy(r => r.FirstName) : results.OrderByDescending(r => r.FirstName);
            //            break;
            //        case "lastname":
            //            results = isAscending == true ? results.OrderBy(r => r.LastName) : results.OrderByDescending(r => r.LastName);
            //            break;
            //        case "age":
            //            results = isAscending == true ? results.OrderBy(r => r.Age) : results.OrderByDescending(r => r.Age);
            //            break;
            //            //case "startingnumber":
            //            //    results = isAscending == true ? results.OrderBy(r => r.StartingNumber) : results.OrderByDescending(r => r.StartingNumber);
            //            //    break;
            //    }
            //}
            // Pagination
            var skip = (pageNumber - 1) * pageSize;
            results = results.Skip(skip).Take(pageSize);

            return await results.ToListAsync();
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

using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Enums;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace GabrovoUltraWebApp.Core.Services
{
    public class RunnerService : IRunnerService
    {
        private readonly IRepository runnerRepository;
        private readonly IAuthService authService;
        public RunnerService(IRepository _runnerRepository, IAuthService _authService)
        {
            runnerRepository = _runnerRepository;
            authService = _authService;

        }
        public async Task<Runner?> CreateAsync(Runner runner)
        {
            runner.UserId = await authService.GetUserIdAsync(runner.Email);
            await runnerRepository.AddAsync(runner);
            await runnerRepository.SaveChangesAsync();
            return runner;
        }

        public async Task<Runner?> DeleteAsync(int id)
        {
            var deletedRunner = await runnerRepository.DeleteAsync<Runner>(id);
            if (deletedRunner == null)
            {
                return null;
            }
            await runnerRepository.SaveChangesAsync();
            return deletedRunner;
        }

        public async Task<List<Runner>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000)
        {
            var runners = runnerRepository.All<Runner>();
            // Filtering
            if (filterOn != null && filterQuery != null)
            {
                filterQuery = filterQuery.ToLower().Trim();
                switch (filterOn.ToLower())
                {
                    case "firstname":
                        runners = runners.Where(r => r.FirstName.ToLower().Contains(filterQuery));
                        break;
                    case "lastname":
                        runners = runners.Where(r => r.LastName.ToLower().Contains(filterQuery));
                        break;
                    case "team":

                        runners = runners.Where(r => r.Team != null && r.Team.ToLower().Contains(filterQuery));
                        break;
                    case "startingnumber":
                        runners = runners.Where(r => r.StartingNumber.ToString().Contains(filterQuery));
                        break;
                    case "age":
                        runners = runners.Where(r => r.Age.ToString().Contains(filterQuery));
                        break;
                    case "gender":

                        if (Enum.TryParse<Gender>(filterQuery, true, out Gender gender))
                        {
                            runners = runners.Where(r => r.Gender == gender);
                        }
                        else
                        {
                            //return empty collection if gencer is invalid
                           runners = runners.Where(g=>false);
                        }
                       
                        break;
                }
            }
            // Sorting
            if (string.IsNullOrEmpty(sortBy) == false)
            {
                switch (sortBy.ToLower())
                {
                    case "firstname":
                        runners = isAscending == true ? runners.OrderBy(r => r.FirstName) : runners.OrderByDescending(r => r.FirstName);
                        break;
                    case "lastname":
                        runners = isAscending == true ? runners.OrderBy(r => r.LastName) : runners.OrderByDescending(r => r.LastName);
                        break;
                    case "age":
                        runners = isAscending == true ? runners.OrderBy(r => r.Age) : runners.OrderByDescending(r => r.Age);
                        break;
                    case "startingnumber":
                        runners = isAscending == true ? runners.OrderBy(r => r.StartingNumber) : runners.OrderByDescending(r => r.StartingNumber);
                        break;
                }
            }
            // Pagination
            var skip = (pageNumber - 1) * pageSize;
            runners = runners.Skip(skip).Take(pageSize);

            return await runners.ToListAsync();
        }

        public async Task<Runner?> GetByIdAsync(int id)
        {
            return await runnerRepository.GetByIdAsync<Runner>(id);
        }

        public async Task<Runner?> UpdateAsync(int id, Runner runner)
        {
            var runnerToUpdate = await runnerRepository.GetByIdAsync<Runner>(id);
            if (runnerToUpdate == null)
            {
                return null;
            }
            runnerToUpdate.FirstName = runner.FirstName;
            runnerToUpdate.LastName = runner.LastName;
            runnerToUpdate.Age = runner.Age;
            runnerToUpdate.Gender = runner.Gender;
            runnerToUpdate.Team = runner.Team;
            runnerToUpdate.StartingNumber = runner.StartingNumber;

            runnerRepository.Update<Runner>(runnerToUpdate);

            await runnerRepository.SaveChangesAsync();
            return runnerToUpdate;
        }
    }
}

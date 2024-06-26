﻿using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
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
        public async Task<ApplicationUser?> CreateAsync(ApplicationUser runner)
        {
            await runnerRepository.AddAsync(runner);
            await runnerRepository.SaveChangesAsync();
            return runner;
        }

        public async Task<ApplicationUser?> DeleteAsync(int id)
        {
            var deletedRunner = await runnerRepository.DeleteAsync<ApplicationUser>(id);
            if (deletedRunner == null)
            {
                return null;
            }
            await runnerRepository.SaveChangesAsync();
            return deletedRunner;
        }

        public async Task<List<RunnerDTO>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000)
        {
            var runners = runnerRepository.All<ApplicationUser>().Where(r => r.Registration != null)
                .Select(r => new RunnerDTO
                {
                    Id = r.Id,
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    Distance = r.Registration.Distance.Name,
                    RegisteredOn = r.Registration.RegistrationDate.ToString("dd/MM/yyyy"),
                    StartingNumber = r.Registration.StartingNumber,
                    Team = r.Team,
                    Age = r.Age,
                    Gender = r.Gender.ToString(),
                });

            //FILTERING 
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
                        runners = runners.Where(r => r.Gender.ToLower().Contains(filterQuery));
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

        public async Task<ApplicationUser?> GetByIdAsync(int id)
        {
            return await runnerRepository.GetByIdAsync<ApplicationUser>(id);
        }

        public async Task<int> GetCountAsync()
        => await runnerRepository.All<ApplicationUser>()
            .Where(r=>r.RegistrationId!=null)
            .CountAsync();
            
        

        public async Task<ApplicationUser?> UpdateAsync(string userId, ApplicationUser runner)
        {
            var runnerToUpdate = await authService.GetUserByIdAsync(userId);
            if (runnerToUpdate == null)
            {
                return null;
            }
            runnerToUpdate.FirstName = runner.FirstName;
            runnerToUpdate.LastName = runner.LastName;
            runnerToUpdate.Age = runner.Age;
            runnerToUpdate.Team = runner.Team;
            runnerToUpdate.City = runner.City;
            runnerToUpdate.Country = runner.Country;

            runnerRepository.Update<ApplicationUser>(runnerToUpdate);

            await runnerRepository.SaveChangesAsync();
            return runnerToUpdate;
        }
    }
}

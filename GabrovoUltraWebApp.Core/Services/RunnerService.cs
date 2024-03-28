using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
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

        public async Task<List<Runner>> GetAllAsync()
        {
           return await runnerRepository.All<Runner>().ToListAsync();
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

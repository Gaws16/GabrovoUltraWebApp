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

        public async Task<Race?> CreateAsync(Race Race)
        {
            await repository.AddAsync(Race);
            await repository.SaveChangesAsync();
            return Race;
        }

        public async Task<Race?> DeleteAsync(int id)
        {
            var deletedRace= await repository.DeleteAsync<Race>(id);
            if (deletedRace == null)
            {
                return null;
            }
            await repository.SaveChangesAsync();
            return deletedRace;
        }

        public async Task<List<Race>> GetAllAsync()
       => await repository.All<Race>().ToListAsync();

        public async Task<Race?> GetByIdAsync(int id)
        => await repository.GetByIdAsync<Race>(id);

        public async Task<Race?> GetCurrentRaceAsync()
        {
            var date = DateTime.Now;
            var currentRace = await repository.All<Race>().FirstOrDefaultAsync(r=>r.Date>=date);
            return currentRace;
        }

        public async Task<Race?> UpdateAsync(int id, Race race)
        {
            var raceToUpdate = await repository.GetByIdAsync<Race>(id);
            if (raceToUpdate == null)
            {
                return null;
            }
            
            raceToUpdate.Location = race.Location;
            raceToUpdate.Name = race.Name;
            raceToUpdate.Date =race.Date;
            repository.Update(raceToUpdate); 
            await repository.SaveChangesAsync();
            return raceToUpdate;
        }
    }
            

}

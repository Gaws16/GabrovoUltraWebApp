using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRepository repository;
        public RegistrationService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<Registration?> CreateAsync(Registration registration)
        {
            //Check if the user has already registered for the current race
            var existingDistance = await repository
                .All<Registration>()
                .FirstOrDefaultAsync(r => r.RaceId == registration.RaceId && r.UserId==registration.UserId );
            if (existingDistance != null)
            {
                return null;
            }
             await repository.AddAsync<Registration>(registration);
            await repository.SaveChangesAsync();
            return registration;
        }

        public async Task<Registration?> DeleteAsync(int id)
        {
            var deletedRegistration = await repository.DeleteAsync<Registration>(id);
            if (deletedRegistration == null)
            {
                return null;
            }
            await repository.SaveChangesAsync();
            return deletedRegistration;
        }

        public async Task<string> GenerateStartingNumber(Distance distance)
        {
            
            distance.Registrations = await repository.All<Registration>().Where(r => r.DistanceId == distance.Id).ToListAsync();
            StringBuilder startingNumber = new StringBuilder();
            startingNumber.Append(distance.Length);
            int count =  distance.Registrations.Count;
            string lastNumber = count>9 ? (count+1).ToString() : "0" + (count+1).ToString();
            startingNumber.Append(lastNumber);
            return startingNumber.ToString();
        }

        public Task<List<Registration>> GetAllAsync()
        {
            return repository.AllReadonly<Registration>().ToListAsync();
        }

        public async Task<Registration?> GetByIdAsync(int id)
        {
             return  await repository.GetByIdAsync<Registration>(id);
        }

        public Task<Registration?> UpdateAsync(int id, Registration Registration)
        {
            throw new NotImplementedException();
        }
    }
}

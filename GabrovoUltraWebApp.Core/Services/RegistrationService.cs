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
        public async Task<Registration?> CreateAsync(Registration registration, ApplicationUser user)
        {
            //Check if the user already has a registration
            if (user.RegistrationId != null)
            {
                return null;
            }

            await repository.AddAsync<Registration>(registration);
            //Update the user with the registration

            user.Registration = registration;
            repository.Update(user);
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
            int count = distance.Registrations.Count;
            string lastNumber = count > 9 ? (count + 1).ToString() : "0" + (count + 1).ToString();
            startingNumber.Append(lastNumber);
            return startingNumber.ToString();
        }

        public Task<List<Registration>> GetAllAsync()
        {
            return repository.AllReadonly<Registration>().ToListAsync();
        }

        public async Task<Registration?> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync<Registration>(id);
        }

        public async Task<Registration?> UpdateAsync(int id, Registration registration)
        {

            var registrationToUpdate = await repository.GetByIdAsync<Registration>(id);
            if (registrationToUpdate == null)
            {
                return null;
            }
            registrationToUpdate.DistanceId = registration.DistanceId;
            registrationToUpdate.UserId = registration.UserId;
            registrationToUpdate.IsPaymentConfirmed = registration.IsPaymentConfirmed;
            registrationToUpdate.RaceId = registration.RaceId;
            registrationToUpdate.StartingNumber = registration.StartingNumber;
            repository.Update(registrationToUpdate);
            await repository.SaveChangesAsync();
            return registrationToUpdate;
        }
    }
}

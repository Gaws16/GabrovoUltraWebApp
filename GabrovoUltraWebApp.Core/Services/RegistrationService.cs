using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Text;

namespace GabrovoUltraWebApp.Core.Services
{
    public class RegistrationService : IRegistrationService
    {
        private readonly IRepository repository;
        private readonly ILoggerFactory
        public RegistrationService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<Registration?> CreateAsync(Distance distance, ApplicationUser user, Race race)
        {
            //Check if the user already has a registration
            if (user.RegistrationId != null)
            {
                return null;
            }
            var registration = new Registration
            {
                DistanceId = distance.Id,
                UserId = user.Id,
                RegistrationDate = DateTime.Now,
                IsPaymentConfirmed = false,
                RaceId = race.Id,
                StartingNumber = await GenerateStartingNumber(distance),
                Result = new Result
                {
                    FinishTme = TimeSpan.Zero,
                    CategoryRank = 0,
                    OverallRank = 0,
                },
            };

            race.Registrations.Add(registration);
            //Update the user with the registration
            user.Registration = registration;
            repository.Update(user);
            repository.Update(registration);
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

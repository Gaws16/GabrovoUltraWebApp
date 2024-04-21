using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using Microsoft.EntityFrameworkCore;
namespace GabrovoUltraWebApp.Core.Services
{
    public class AdminService : IAdminService
    {
        private readonly IRepository repository;

        public AdminService(IRepository _repository)
        {
            repository = _repository;
        }

        public async Task<ApplicationUser> DeleteUser(string id)
        {

            var deletedUser = await repository.DeleteAsync<ApplicationUser>(id);
            if (deletedUser is null)
            {
                return null;
            }
            await repository.SaveChangesAsync();
            return deletedUser;
        }
        private string FormatResult(TimeSpan? result)
        {
            if (result == null)
            {
                return "Not finished";
            }
            var stringResult = $"{result.Value.Hours}:{result.Value.Minutes}:{result.Value.Seconds}";
            return stringResult;
        }
        public async Task<List<DisplayUsersDTO>> GetAllUsers()
        {

            var users = await repository.All<ApplicationUser>()
                                        .Include(r => r.Registration)
                                        .ThenInclude(d => d.Distance)
                                        .Select(u => new DisplayUsersDTO
                                        {
                                            Id = u.Id,
                                            FirstName = u.FirstName,
                                            LastName = u.LastName,
                                            Email = u.Email,
                                            Age = u.Age,
                                            Team = u.Team,
                                            StartingNumber = u.Registration.StartingNumber,
                                            City = u.City,
                                            Country = u.Country,
                                            Distance = u.Registration.Distance.Name,
                                            Result = u.Registration.Result == null ?
                                            "Not Finished" : u.Registration.Result.FinishTme.Value.ToString(),
                                            Race = u.Registration.Race.Name,
                                            Gender = u.Gender.ToString()

                                        }).ToListAsync();
            return users;
        }

        public async Task<AdminUpdateRequestDTO> UpdateUser(string userId, AdminUpdateRequestDTO user)
        {
            var userToUpdate = await repository.GetByIdAsync<ApplicationUser>(userId);
            var registration = await repository.All<Registration>()
                .Include(r => r.Result)
                .FirstOrDefaultAsync(r => r.UserId == userId);
            if (TimeSpan.TryParse(user.Result, out TimeSpan result) == false)
            {
                return null;
            }
            if (userToUpdate is null || registration is null)
            {
                return null;
            }
            userToUpdate.FirstName = user.FirstName;
            userToUpdate.LastName = user.LastName;
            userToUpdate.Age = user.Age;
            userToUpdate.Team = user.Team;
            userToUpdate.City = user.City;
            userToUpdate.Country = user.Country;
            registration.StartingNumber = user.StartingNumber;
            registration.Result.FinishTme = result;
            registration.DistanceId = user.DistanceId;
            registration.RaceId = user.RaceId;

            repository.Update(userToUpdate);
            repository.Update(registration);
            await repository.SaveChangesAsync();

            return user;

        }
    }
}

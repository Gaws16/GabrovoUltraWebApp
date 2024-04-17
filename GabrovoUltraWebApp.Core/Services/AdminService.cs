using GabrovoUltraWebApp.Core.Services.Contracts;
using GabrovoUltraWebApp.Infrastructure.Data.Common;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public async Task<List<DisplayUsersDTO>> GetAllUsers(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending, int pageNumber = 1, int pageSize = 1000)
        {
            var users = await repository.All<ApplicationUser>()
                                        .Include(r=>r.Registration)
                                        .ThenInclude(d=>d.Distance)
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
                                            Result = u.Registration.Result.FinishTme.ToString(),
                                            Race = u.Registration.Race.Name,
                                            Gender = u.Gender.ToString()

                                        }).ToListAsync();
                return users;
        }
    }
}

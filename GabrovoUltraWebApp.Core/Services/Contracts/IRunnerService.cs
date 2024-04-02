using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRunnerService
    {
        Task<List<ApplicationUser>> GetAllAsync(string? filterOn = null, string? filterQuery = null,
                                        string? sortBy = null, bool? isAscending = true,
                                        int pageNumber = 1, int pageSize = 1000);

        Task<ApplicationUser?> GetByIdAsync(int id);

        Task<ApplicationUser?> CreateAsync(ApplicationUser runner);

        Task<ApplicationUser?> UpdateAsync(int id, ApplicationUser runner);

        Task<ApplicationUser?> DeleteAsync(int id);
    }
}

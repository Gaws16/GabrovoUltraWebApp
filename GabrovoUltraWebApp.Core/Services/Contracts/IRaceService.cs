using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRaceService
    {
        Task<List<Race>> GetAllAsync();
       
        Task<Race?> GetByIdAsync(int id);

        Task<Race?> CreateAsync(Race Race);

        Task<Race?> UpdateAsync(int id, Race Race);

        Task<Race?> DeleteAsync(int id);
    }
}

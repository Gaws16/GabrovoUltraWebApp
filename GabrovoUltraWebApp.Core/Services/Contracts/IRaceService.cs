using GabrovoUltraWebApp.Infrastructure.Data.Models;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IRaceService
    {
        Task<List<Race>> GetAllAsync();
    }
}

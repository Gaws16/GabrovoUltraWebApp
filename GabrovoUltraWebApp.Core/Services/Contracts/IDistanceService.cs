using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IDistanceService
    {
        Task<List<Distance>> GetAllAsync();

        Task<Distance?> GetByIdAsync(int id);

        Task<Distance?> CreateAsync(Distance distance);

        Task<Distance?> UpdateAsync(int id, Distance distance);

        Task<Distance?> DeleteAsync(int id);


    }
}

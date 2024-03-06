using GabrovoUltraWebApp.Infrastructure.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GabrovoUltraWebApp.Core.Services.Contracts
{
    public interface IHeroSectionService
    {
        Task<ICollection<HeroSection>> GetAllHeroSectionsAsyncReadOnly();
    }
}

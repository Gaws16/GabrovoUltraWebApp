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
        Task<HeroSection?> GetHeroSectionByIdAsync(int id);

        Task<HeroSection> CreateHeroSectionAsync(HeroSection heroSection);

        Task<HeroSection?> UpdateHeroSectionAsync(int id, HeroSection heroSection);

        Task<HeroSection?> DeleteHeroSectionAsync(int id);

    }
}

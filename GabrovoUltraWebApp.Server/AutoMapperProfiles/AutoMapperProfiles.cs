using AutoMapper;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.DTO;
using GabrovoUltraWebApp.Infrastructure.Models.ExportDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
using System.Globalization;
using static GabrovoUltraWebApp.Infrastructure.Common.DataValidationConstants.Race;

namespace GabrovoUltraWebApp.Infrastructure.AutoMapperProfiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Distance, DistanceDTO>().ReverseMap();
            CreateMap<Distance, CreateDistanceRequestDTO>().ReverseMap();
            CreateMap<Distance, UpdateDistanceRequestDTO>().ReverseMap();

            CreateMap<HeroSection, HeroSectionDTO>().ReverseMap();
            CreateMap<HeroSection, CreateHeroSectionRequestDTO>().ReverseMap();
            CreateMap<HeroSection, UpdateHeroSectionRequestDTO>().ReverseMap();

            CreateMap<CreateOrUpdateRaceRequestDTO,Race>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.ParseExact(src.Date,DateTimeFormat,CultureInfo.InvariantCulture)))
                .ReverseMap();
            CreateMap<Race,RaceDTO>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString(DateTimeFormat)))
                .ReverseMap();
        }
    }
}

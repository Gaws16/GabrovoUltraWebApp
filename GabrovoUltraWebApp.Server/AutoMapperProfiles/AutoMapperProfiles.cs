using AutoMapper;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.RequestDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResponseDTO;
using GabrovoUltraWebApp.Infrastructure.Models.ResposneDTO;
using System.Globalization;
using System.Security.Claims;
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

            CreateMap<Runner,RunnerDTO>()
                .ForMember(dest=>dest.Gender, opt=>opt.MapFrom(src=> src.Gender.ToString()))
                .ReverseMap();
            CreateMap<CreateRunnerRequestDTO,Runner>()
                .ReverseMap();

            CreateMap<RegisterRequestDTO, Runner>().ReverseMap();
                
        }
    }
}

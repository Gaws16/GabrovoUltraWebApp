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
            CreateMap<Distance, JoinDistanceRequestDTO>().ReverseMap();

            CreateMap<HeroSection, HeroSectionDTO>().ReverseMap();
            CreateMap<HeroSection, CreateHeroSectionRequestDTO>().ReverseMap();
            CreateMap<HeroSection, UpdateHeroSectionRequestDTO>().ReverseMap();

            CreateMap<CreateOrUpdateRaceRequestDTO,Race>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => DateTime.ParseExact(src.Date,DateTimeFormat,CultureInfo.InvariantCulture)))
                .ReverseMap();
            CreateMap<Race,RaceDTO>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date.ToString(DateTimeFormat)))
                .ReverseMap();

            CreateMap<ApplicationUser,RunnerDTO>()
                .ForMember(dest=>dest.Gender, opt=>opt.MapFrom(src=> src.Gender.ToString()))
                .ReverseMap();
            CreateMap<CreateRunnerRequestDTO,ApplicationUser>().ReverseMap();
            CreateMap<UpdateRunnerRequestDTO,ApplicationUser>().ReverseMap();
            CreateMap<RegisterRequestDTO, ApplicationUser>()
                .ForMember(dest=>dest.Email, opt=>opt.MapFrom(src=>src.Username))
                .ReverseMap();

            CreateMap<ApplicationUser,RegisterRequestDTO>().ReverseMap();

            CreateMap<Registration, RegistrationDTO>()
                .ForMember(dest => dest.RegistrationDate, opt => opt.MapFrom(src => src.RegistrationDate.ToString(DateTimeFormat)))
                .ReverseMap();
            CreateMap<Registration, UpdateRegistrationRequestDTO>()
                .ReverseMap();
                
        }
    }
}

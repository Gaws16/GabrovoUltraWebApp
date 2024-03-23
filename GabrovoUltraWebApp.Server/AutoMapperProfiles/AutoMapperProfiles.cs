using AutoMapper;
using GabrovoUltraWebApp.Infrastructure.Data.Models;
using GabrovoUltraWebApp.Infrastructure.Models.DTO;
using GabrovoUltraWebApp.Infrastructure.Models.ImportDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GabrovoUltraWebApp.Infrastructure.AutoMapperProfiles
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Distance, DistanceDTO>().ReverseMap();
            CreateMap<Distance, CreateDistanceRequestDTO>().ReverseMap();
            CreateMap<Distance, UpdateDistanceRequestDTO>().ReverseMap();
        }
    }
}

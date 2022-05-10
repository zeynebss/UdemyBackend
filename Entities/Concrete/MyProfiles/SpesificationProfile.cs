using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class SpesificationProfile:Profile
    {
        public SpesificationProfile()
        {
            CreateMap<CourseSpesification, SpesificationDTO>()
           .ForMember(
               dest => dest.Description,
               opt => opt.MapFrom(src => src.Description)
               );
        }
    }
}

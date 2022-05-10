using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<Instructor, InstructorDTO>()
             .ForMember(
              dest => dest.ID,
              opt => opt.MapFrom(src => src.ID)
              )
            .ForMember(
             dest => dest.FullName,
             opt => opt.MapFrom(src => src.FullName)
              )
            .ForMember(
             dest => dest.PhotoUrl,
             opt => opt.MapFrom(src => src.PhotoUrl)
              )
             .ForMember(
             dest => dest.Speciality,
             opt => opt.MapFrom(src => src.Speciality)
              );
        }
    }
}

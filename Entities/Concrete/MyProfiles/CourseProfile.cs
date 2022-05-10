using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<Course, CourseDTO>()
            .ForMember(
            dest => dest.ID,
            opt => opt.MapFrom(src => src.ID)
              )
            .ForMember(
                dest => dest.CategoryId,
                opt => opt.MapFrom(src => src.CategoryId)
                )
              .ForMember(
                dest => dest.CategoryName,
                opt => opt.MapFrom(src => src.Category.Name)
                )
               .ForMember(
                dest => dest.InstructorName,
                opt => opt.MapFrom(src => src.Insturctor.FullName)
                )
                .ForMember(
                dest => dest.InstructorId,
                opt => opt.MapFrom(src => src.InstructorId)
                )
                 .ForMember(
                dest => dest.Name,
                opt => opt.MapFrom(src => src.Name)
                )
                .ForMember(
                dest => dest.Price,
                opt => opt.MapFrom(src => src.Price)
                )
                .ForMember(
                dest => dest.Discount,
                opt => opt.MapFrom(src => src.Discount)
                )
                .ForMember(
                dest => dest.Raiting,
                opt => opt.MapFrom(src => src.Raiting)
                )
             .ForMember(
                dest => dest.PhotoUrl,
                opt => opt.MapFrom(src => src.PhotoUrl)
                )
              .ForMember(
                dest => dest.Description,
                opt => opt.MapFrom(src => src.Description)
                )
             .ForMember(
                dest => dest.PublishDate,
                opt => opt.MapFrom(src => src.PublishDate)
                )
             .ForMember(
                dest => dest.Spesification,
                opt => opt.MapFrom(src => src.CourseSpesification.Where(x => x.CourseId == src.ID))
                );
        }
    }
}

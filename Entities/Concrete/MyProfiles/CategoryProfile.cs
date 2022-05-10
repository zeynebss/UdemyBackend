using AutoMapper;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.MyProfiles
{
    public class CategoryProfile:Profile
    {
        public CategoryProfile()
        {
            CreateMap<Category, CategoryListDTO>()
         .ForMember(
         dest => dest.ID,
         opt => opt.MapFrom(src => src.ID)
           )
         .ForMember(
             dest => dest.Name,
             opt => opt.MapFrom(src => src.Name)
             );
        }
    }
}

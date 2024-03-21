using AutoMapper;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.MappingProfile
{
    public class PortionMapProfile : Profile
    {
        public PortionMapProfile()
        {

            //CreateMap<PersonMealModel, PersonMeal>().ReverseMap();

            CreateMap<PortionModel, Portion>().
            ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).
            ForMember(a => a.Size, b => b.MapFrom(src => src.Size)).      
            //ForMember(a => a.PersonMeals, b => b.MapFrom(src => src.PersonMeals)).
            ReverseMap();

        }
        
    }
}

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
    public class MealMapProfile : Profile
    {
        public MealMapProfile()
        {
            CreateMap<MealModel, Meal>().
            ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).
            ForMember(a => a.Calorie, b => b.MapFrom(src => src.Calorie)).
            ForMember(a => a.Status, b => b.MapFrom(src => src.Status)).
            ForMember(a => a.MealName, b => b.MapFrom(src => src.MealName)).
            ForMember(a => a.Description, b => b.MapFrom(src => src.Description)).

            ReverseMap();
        }
    }
}

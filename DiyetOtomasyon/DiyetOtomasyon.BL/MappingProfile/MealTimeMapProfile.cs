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
    public class MealTimeMapProfile : Profile
    {
        public MealTimeMapProfile()
        {
            CreateMap<MealTimeModel, MealTime>().
            ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).
            ForMember(a => a.Name, b => b.MapFrom(src => src.Name)).
            ReverseMap();
        }
    }
}

﻿using AutoMapper;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.MappingProfile
{
    public class PersonMealMapProfile : Profile
    {
        public PersonMealMapProfile()
        {
            CreateMap<PersonMealModel, PersonMeal>().
            ForMember(entity => entity.MealId, model => model.MapFrom(src => src.MealId)).
            ForMember(entity => entity.PersonId, model => model.MapFrom(src => src.PersonId)).
            ForMember(entity => entity.PortionSize, model => model.MapFrom(src => src.PortionSize)).
            ForMember(entity => entity.MealTime, model => model.MapFrom(src => src.MealTime)).
            ReverseMap();

        }
    }
}

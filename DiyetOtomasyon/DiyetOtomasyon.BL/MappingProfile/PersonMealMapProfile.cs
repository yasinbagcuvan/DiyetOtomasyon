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
    public class PersonMealMapProfile : Profile
    {
        public PersonMealMapProfile()
        {
            CreateMap<PersonModel, Person>().ReverseMap();  
            CreateMap<PortionModel, Portion>().ReverseMap();
            CreateMap<MealTimeModel, MealTime>().ReverseMap();
            CreateMap<MealModel, Meal>().ReverseMap();


            CreateMap<PersonMealModel, PersonMeal>().
            ForMember(entity => entity.MealId, model => model.MapFrom(src => src.MealId)).
            ForMember(entity => entity.PersonId, model => model.MapFrom(src => src.PersonId)).
            ForMember(entity => entity.MealTimeId, model => model.MapFrom(src => src.MealTimeId)).
            ForMember(entity => entity.CreatedDate, model => model.MapFrom(src => src.CreatedDate)).
            ForMember(entity => entity.PortionId, model => model.MapFrom(src => src.PortionId)).
            ForMember(entity => entity.MealTime, model => model.MapFrom(src => src.MealTime)).
            ForMember(entity => entity.Portion, model => model.MapFrom(src => src.Portion)).
            ForMember(entity => entity.Meal, model => model.MapFrom(src => src.Meal)).
            ForMember(entity => entity.Person, model => model.MapFrom(src => src.Person)).

            ReverseMap();

        }
    }
}

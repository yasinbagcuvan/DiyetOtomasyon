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
    //mapperda navigation propperty'leri de içebilmek için kullanacağız profil sınıf
    public class PersonMapProfile : Profile
    {
        public PersonMapProfile()
        {

            CreateMap<IEnumerable<PersonMeal>,Person>();

            CreateMap<PersonModel,Person >().
                ForMember(a => a.Id, b => b.MapFrom(src => src.Id)).
                ForMember(a => a.Email, b => b.MapFrom(src => src.Email)).
                ForMember(a => a.Status, b => b.MapFrom(src => src.Status)).
                ForMember(a => a.FirstName, b => b.MapFrom(src => src.FirstName)).
                ForMember(a => a.LastName, b => b.MapFrom(src => src.LastName)).
                ForMember(a => a.Password, b => b.MapFrom(src => src.Password)).
                ForMember(a => a.PersonMeals, b => b.MapFrom(src => src.PersonMeals)).
            ReverseMap();

        }
    }
}

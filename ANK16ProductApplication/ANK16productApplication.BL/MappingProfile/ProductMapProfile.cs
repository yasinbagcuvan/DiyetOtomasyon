using ANK16productApplication.BL.Models;
using ANK16ProductApplication.DAL.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16productApplication.BL.MappingProfile
{

    //mapperda navigation propperty'leri de içebilmek için kullanacağız profil sınıf
    public class ProductMapProfile : Profile
    {
        public ProductMapProfile()
        {
            CreateMap<BrandModel, Brand>().
            ForMember(a => a.Products, b => b.MapFrom(src => src.ProductModels)).ReverseMap();

        }
    }
}

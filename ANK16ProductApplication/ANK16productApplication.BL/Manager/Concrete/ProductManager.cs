using ANK16productApplication.BL.Manager.Abstract;
using ANK16productApplication.BL.MappingProfile;
using ANK16productApplication.BL.Models;
using ANK16ProductApplication.DAL.Context;
using ANK16ProductApplication.DAL.Entities;
using ANK16ProductApplication.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16productApplication.BL.Manager.Concrete
{
    public class ProductManager : Manager<ProductModel,Product, ProductMapProfile>
    {
        public ProductManager()
        {
            _repository = new ProductRepository(new ProductDbContext());
        }
    }
}

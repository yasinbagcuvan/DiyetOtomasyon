using ANK16ProductApplication.DAL.Context;
using ANK16ProductApplication.DAL.Entities;
using ANK16ProductApplication.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16ProductApplication.DAL.Repository.Concrete
{
    public class ProductRepository : Repository<Product>
    {
        public ProductRepository(ProductDbContext db) : base(db) 
        {
                
        }
    }
}

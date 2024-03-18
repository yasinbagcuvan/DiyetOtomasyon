using ANK16ProductApplication.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16ProductApplication.DAL.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }

        public double Price { get; set; }


        public Brand Brand { get; set; }
        public int? BrandId { get; set; }
    }
}

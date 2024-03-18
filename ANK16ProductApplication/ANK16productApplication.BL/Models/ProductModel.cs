using ANK16ProductApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16productApplication.BL.Models
{
    public class ProductModel
    {

        // UI ile DAL arasındaki geçiş objeleri

        public int Id { get; set; }
        public string Name { get; set; }

        public double Price { get; set; }

        public BrandModel Brand { get; set; }
        public int? BrandId { get; set; }



    }
}

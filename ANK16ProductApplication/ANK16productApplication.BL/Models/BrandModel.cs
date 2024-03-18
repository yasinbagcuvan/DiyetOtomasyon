using ANK16ProductApplication.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16productApplication.BL.Models
{
    public class BrandModel
    {
        public string Name { get; set; }


        public List<ProductModel> ProductModels { get; set; }
    }
}

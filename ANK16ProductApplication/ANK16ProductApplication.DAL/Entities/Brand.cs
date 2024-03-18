using ANK16ProductApplication.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ANK16ProductApplication.DAL.Entities
{
    public class Brand : Entity
    {
        public string Name { get; set; }


        public List<Product> Products { get; set; }
    }
}

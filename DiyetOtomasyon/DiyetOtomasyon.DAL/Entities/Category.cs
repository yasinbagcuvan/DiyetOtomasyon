using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Entities
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }
        public virtual List<Meal> Meals { get; set; }
        public override string ToString()
        {
            return CategoryName;
        }
    }
}

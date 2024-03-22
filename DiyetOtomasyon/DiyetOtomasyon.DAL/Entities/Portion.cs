using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Entities
{
    public class Portion : Entity
    {
        //public string Type { get; set; }
        public int Size  { get; set; }
        public virtual List<PersonMeal> PersonMeals { get; set; }
        public override string ToString()
        {
            return Size.ToString();
        }
    }
    
}

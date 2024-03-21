using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Models
{
    public class PortionModel
    {
        public int Id { get; set; }
        //public string Type { get; set; }
        public int Size { get; set; }
        //public List<PersonMealModel> PersonMeals { get; set; }

        public override string ToString()
        {
            return Size.ToString();
        }
    }
}

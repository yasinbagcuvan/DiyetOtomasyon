using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Models
{
    public class MealModel
    {
        public int Id { get; set; }
        public string MealName { get; set; }
        public string Description { get; set; }
        public short Calorie { get; set; }
        //public Status Status { get; set; }
        //public  CategoryModel Category { get; set; }
        
        public  int CategoryId { get; set; }
        //public List<PersonMealModel> PersonMeals { get; set; }
        public override string ToString()
        {
            return MealName;
        }

    }
}

using DiyetOtomasyon.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Models
{
    public class MealTimeModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedTime { get; set; }
        //public List<PersonMealModel> PersonMeals { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}

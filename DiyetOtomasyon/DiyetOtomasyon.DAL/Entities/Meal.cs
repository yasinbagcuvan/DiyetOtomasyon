using DiyetOtomasyon.DAL.Enums;
using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Entities
{
    public class Meal : Entity
    {
        public string MealName { get; set; }
        public string Description { get; set; }
        public short Calorie {  get; set; }
        //public ICollection<Person> Persons { get; set; }
        public ICollection<PersonMeal> PersonMeals { get; set; }
    }
}

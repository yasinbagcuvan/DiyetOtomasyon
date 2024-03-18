using DiyetOtomasyon.DAL.Enums;
using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Entities
{
    public class PersonMeal : Entity
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set;}
        public MealTime MealTime { get; set; }
        public byte PortionSize { get; set; }
    }
}

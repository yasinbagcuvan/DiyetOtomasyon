using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Models
{
    public class PersonMealModel
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }
        public int MealId { get; set; }
        public Meal Meal { get; set; }
        public MealTime MealTime { get; set; }
        public byte PortionSize { get; set; }
        public Status Status { get; set; }
    }
}

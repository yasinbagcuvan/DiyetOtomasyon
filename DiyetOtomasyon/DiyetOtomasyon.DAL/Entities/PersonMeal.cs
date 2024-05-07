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

        public  int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public  int MealId { get; set; }
        public virtual Meal Meal { get; set;}
        public int MealTimeId { get; set; }
        public virtual MealTime MealTime { get; set; }
        public virtual Portion Portion { get; set; }
        public int PortionId { get; set; }
        

    }
}

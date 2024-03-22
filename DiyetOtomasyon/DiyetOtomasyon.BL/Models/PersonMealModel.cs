using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Enums;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Models
{
    public class PersonMealModel
    {
        public  int PersonId { get; set; }
        public  PersonModel Person { get; set; }
        public  int MealId { get; set; }
        public  MealModel Meal { get; set; }
        public  int MealTimeId { get; set; }
        public  MealTimeModel MealTime { get; set; }
        public  int PortionId { get; set; }
        public  PortionModel Portion { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }
    }
}

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
        public string Name { get; set; }
        public string Description { get; set; }
        public short Calorie { get; set; }
        public Status Status { get; set; }

    }
}

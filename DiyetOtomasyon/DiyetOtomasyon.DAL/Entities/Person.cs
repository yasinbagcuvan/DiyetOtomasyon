using DiyetOtomasyon.DAL.Enums;
using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Entities
{
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //public ICollection<Meal> Meals { get; set; }
        public ICollection<PersonMeal> PersonMeals { get; set; }


    }
}

using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.DAL.Repository.Concrete
{
    public class PersonMealRepository : Repository<PersonMeal>
    {
        public PersonMealRepository(DiyetDbContext db) : base(db)
        {

        }

    }
}

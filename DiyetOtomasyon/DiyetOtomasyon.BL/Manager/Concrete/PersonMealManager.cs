﻿using DiyetOtomasyon.BL.Manager.Abstract;
using DiyetOtomasyon.BL.MappingProfile;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiyetOtomasyon.BL.Manager.Concrete
{
    public class PersonMealManager : Manager<PersonMealModel, PersonMeal, PersonMealMapProfile>
    {
        public PersonMealManager()
        {
            _repository = new PersonMealRepository(new DiyetDbContext());
        }
    }
}

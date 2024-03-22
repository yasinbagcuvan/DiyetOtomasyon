using DiyetOtomasyon.BL.Manager.Abstract;
using DiyetOtomasyon.BL.Models;
using DiyetOtomasyon.BL.MappingProfile;
using DiyetOtomasyon.DAL.Context;
using DiyetOtomasyon.DAL.Entities;
using DiyetOtomasyon.DAL.Repository.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiyetOtomasyon.DAL.Repository.Abstract;

namespace DiyetOtomasyon.BL.Manager.Concrete
{
    public class PersonManager : Manager<PersonModel, Person, PersonMapProfile>
    {
        public PersonManager()
        {
            _repository = new PersonRepository(new DiyetDbContext());
        }
        public PersonModel? FindUser(string Email, string Password)
        {
            IPersonRepository repo = _repository as IPersonRepository;
            Person person=repo.FindUser(Email, Password);
            return _mapper.Map<PersonModel>(person);
        }
        public PersonModel? FindUser(string Email)
        {
            IPersonRepository repo = _repository as IPersonRepository;
            Person person = repo.FindUser(Email);
            return _mapper.Map<PersonModel>(person);
        }



    }
}

using DiyetOtomasyon.DAL.Entities;

namespace DiyetOtomasyon.DAL.Repository.Abstract
{
    public interface IPersonRepository
    {
        Person FindUser(string email, string password);
        Person FindUser(string Email);
    }
}
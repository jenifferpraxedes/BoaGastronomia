using BoaGastronomia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAll();

        Task<User> GetById(int id);

        User Add(User user);

        User Update(User user);

        void Delete(User user);
    }
}
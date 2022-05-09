using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        protected BoaGastronomiaDBContext _boaGastronomiaDBContext1;
        protected DbSet<User> _dbSet;

        public UserRepository(BoaGastronomiaDBContext boaGastronomiaDBContext)
        {
            _boaGastronomiaDBContext1 = boaGastronomiaDBContext;
            _dbSet = _boaGastronomiaDBContext1.Set<User>();
        }

        public async Task<List<User>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public User Add(User user)
        {
            _dbSet.Add(user);
            return user;
        }

        public User Update(User user)
        {
            _dbSet.Update(user);
            return user;
        }

        public void Delete(User user)
        {
            _dbSet.Remove(user);
        }
    }
}
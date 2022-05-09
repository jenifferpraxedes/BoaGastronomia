using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Implementations
{
    public class RatingRepository : IRatingRepository
    {
        protected BoaGastronomiaDBContext _boaGastronomiaDBContext1;
        protected DbSet<Rating> _dbSet;

        public RatingRepository(BoaGastronomiaDBContext boaGastronomiaDBContext)
        {
            _boaGastronomiaDBContext1 = boaGastronomiaDBContext;
            _dbSet = _boaGastronomiaDBContext1.Set<Rating>();
        }

        public async Task<List<Rating>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Rating> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Rating Add(Rating rating)
        {
            _dbSet.Add(rating);
            return rating;
        }

        public Rating Update(Rating rating)
        {
            _dbSet.Update(rating);
            return rating;
        }

        public void Delete(Rating rating)
        {
            _dbSet.Remove(rating);
        }
    }
}
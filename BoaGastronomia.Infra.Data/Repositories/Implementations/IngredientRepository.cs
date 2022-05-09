using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Implementations
{
    public class IngredientRepository : IIngredientRepository
    {
        protected BoaGastronomiaDBContext _boaGastronomiaDBContext1;
        protected DbSet<Ingredient> _dbSet;

        public IngredientRepository(BoaGastronomiaDBContext boaGastronomiaDBContext)
        {
            _boaGastronomiaDBContext1 = boaGastronomiaDBContext;
            _dbSet = _boaGastronomiaDBContext1.Set<Ingredient>();
        }

        public async Task<List<Ingredient>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Ingredient> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Ingredient Add(Ingredient ingredient)
        {
            _dbSet.Add(ingredient);
            return ingredient;
        }

        public Ingredient Update(Ingredient ingredient)
        {
            _dbSet.Update(ingredient);
            return ingredient;
        }

        public void Delete(Ingredient ingredient)
        {
            _dbSet.Remove(ingredient);
        }
    }
}
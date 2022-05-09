using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Implementations
{
    public class RecipeRepository : IRecipeRepository
    {
        protected BoaGastronomiaDBContext _boaGastronomiaDBContext1;
        protected DbSet<Recipe> _dbSet;

        public RecipeRepository(BoaGastronomiaDBContext boaGastronomiaDBContext)
        {
            _boaGastronomiaDBContext1 = boaGastronomiaDBContext;
            _dbSet = _boaGastronomiaDBContext1.Set<Recipe>();
        }

        public async Task<List<Recipe>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<Recipe> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public Recipe Add(Recipe recipe)
        {
            _dbSet.Add(recipe);
            return recipe;
        }

        public Recipe Update(Recipe recipe)
        {
            _dbSet.Update(recipe);
            return recipe;
        }

        public void Delete(Recipe recipe)
        {
            _dbSet.Remove(recipe);
        }
    }
}
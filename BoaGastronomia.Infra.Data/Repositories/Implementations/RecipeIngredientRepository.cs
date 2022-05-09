using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Implementations
{
    public class RecipeIngredientRepository : IRecipeIngredientRepository
    {
        protected BoaGastronomiaDBContext _boaGastronomiaDBContext1;
        protected DbSet<RecipeIngredient> _dbSet;

        public RecipeIngredientRepository(BoaGastronomiaDBContext boaGastronomiaDBContext)
        {
            _boaGastronomiaDBContext1 = boaGastronomiaDBContext;
            _dbSet = _boaGastronomiaDBContext1.Set<RecipeIngredient>();
        }

        public async Task<List<RecipeIngredient>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<RecipeIngredient> GetById(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public RecipeIngredient Add(RecipeIngredient recipeIngredientcipe)
        {
            _dbSet.Add(recipeIngredientcipe);
            return recipeIngredientcipe;
        }

        public RecipeIngredient Update(RecipeIngredient recipeIngredientcipe)
        {
            _dbSet.Update(recipeIngredientcipe);
            return recipeIngredientcipe;
        }

        public void Delete(RecipeIngredient recipeIngredientcipe)
        {
            _dbSet.Remove(recipeIngredientcipe);
        }
    }
}
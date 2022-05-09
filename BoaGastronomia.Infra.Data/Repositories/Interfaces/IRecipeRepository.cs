using BoaGastronomia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Interfaces
{
    public interface IRecipeRepository
    {
        Task<List<Recipe>> GetAll();

        Task<Recipe> GetById(int id);

        Recipe Add(Recipe recipe);

        Recipe Update(Recipe recipe);

        void Delete(Recipe recipe);
    }
}
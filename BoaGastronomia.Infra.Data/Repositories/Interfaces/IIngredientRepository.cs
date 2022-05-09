using BoaGastronomia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Interfaces
{
    public interface IIngredientRepository
    {
        public Task<List<Ingredient>> GetAll();

        public Task<Ingredient> GetById(int id);

        public Ingredient Add(Ingredient ingredient);

        public Ingredient Update(Ingredient ingredient);

        void Delete(Ingredient ingredient);
    }
}
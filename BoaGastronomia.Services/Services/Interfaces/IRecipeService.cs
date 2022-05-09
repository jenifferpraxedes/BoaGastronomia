using BoaGastronomia.Services.Mapping.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Interfaces
{
    public interface IRecipeService
    {
        public Task<List<RecipeDto>> GetAll();

        public Task<RecipeDto> GetById(int id);

        public Task<RecipeDto> Save(RecipeDto recipeDto);

        public Task Delete(RecipeDto recipeDto);
    }
}
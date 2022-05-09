using BoaGastronomia.Services.Mapping.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Interfaces
{
    public interface IRecipeIngredientService
    {
        public Task<List<RecipeIngredientDto>> GetAll();

        public Task<RecipeIngredientDto> GetById(int id);

        public Task<RecipeIngredientDto> Save(RecipeIngredientDto recipeIngredientDto);

        public Task Delete(RecipeIngredientDto recipeIngredientDto);
    }
}
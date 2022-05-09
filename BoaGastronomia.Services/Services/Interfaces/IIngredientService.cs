using BoaGastronomia.Services.Mapping.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Interfaces
{
    public interface IIngredientService
    {
        public Task<List<IngredientDto>> GetAll();

        public Task<IngredientDto> GetById(int id);

        public Task<IngredientDto> Save(IngredientDto ingredientDto);

        public Task Delete(IngredientDto ingredientDto);

        /*object Save(IngredientDto ingredientDto);
        object GetById(IIngredientService ingredientService);
        object GetAll();
        object GetById(int id);
        void Delete(IngredientDto ingredientDto);                                   <- PRECISO DISTO TUDO??   */
    }
}
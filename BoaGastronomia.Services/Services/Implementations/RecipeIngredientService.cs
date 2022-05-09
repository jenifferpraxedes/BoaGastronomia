using AutoMapper;
using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Implementations
{
    public class RecipeIngredientService : IRecipeIngredientService
    {
        private readonly IMapper _mapper;
        private readonly IRecipeIngredientRepository _repository;
        private readonly BoaGastronomiaDBContext _context;

        public RecipeIngredientService(IMapper mapper, IRecipeIngredientRepository repository, BoaGastronomiaDBContext context)
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;
        }

        public async Task<List<RecipeIngredientDto>> GetAll()
        {
            List<RecipeIngredient> recipeIngredients = await _repository.GetAll();
            return _mapper.Map<List<RecipeIngredientDto>>(recipeIngredients);
        }

        public async Task<RecipeIngredientDto> GetById(int id)
        {
            RecipeIngredient recipeIngredient = await _repository.GetById(id);
            return _mapper.Map<RecipeIngredientDto>(recipeIngredient);
        }

        public async Task<RecipeIngredientDto> Save(RecipeIngredientDto recipeIngredientDto)
        {
            RecipeIngredient recipeIngredient = _mapper.Map<RecipeIngredient>(recipeIngredientDto);
            if (recipeIngredientDto.Id > 0)
            {
                _repository.Update(recipeIngredient);
            }
            else
            {
                _repository.Add(recipeIngredient);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<RecipeIngredientDto>(recipeIngredient);
        }

        public async Task Delete(RecipeIngredientDto recipeIngredientDto)
        {
            RecipeIngredient recipeIngredient = _mapper.Map<RecipeIngredient>(recipeIngredientDto);

            _repository.Delete(recipeIngredient);

            await _context.SaveChangesAsync();
        }
    }
}
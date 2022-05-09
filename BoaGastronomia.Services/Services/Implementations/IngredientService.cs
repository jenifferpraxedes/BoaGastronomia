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
    public class IngredientService : IIngredientService
    {
        private readonly IMapper _mapper;
        private readonly IIngredientRepository _repository;
        private readonly BoaGastronomiaDBContext _context;

        public IngredientService(IMapper mapper, IIngredientRepository repository, BoaGastronomiaDBContext context)
        {
            _mapper = mapper;
            _context = context;
            _repository = repository;
        }

        public async Task<List<IngredientDto>> GetAll()
        {
            List<Ingredient> ingredients = await _repository.GetAll();
            return _mapper.Map<List<IngredientDto>>(ingredients);
        }

        public async Task<IngredientDto> GetById(int id)
        {
            Ingredient ingredient = await _repository.GetById(id);
            return _mapper.Map<IngredientDto>(ingredient);
        }

        public async Task<IngredientDto> Save(IngredientDto ingredientDto)
        {
            Ingredient ingredient = _mapper.Map<Ingredient>(ingredientDto);
            if (ingredientDto.Id > 0)
            {
                _repository.Update(ingredient);
            }
            else
            {
                _repository.Add(ingredient);
            }
            await _context.SaveChangesAsync();

            return _mapper.Map<IngredientDto>(ingredient);
        }

        public async Task Delete(IngredientDto ingredientDto)
        {
            Ingredient ingredient = _mapper.Map<Ingredient>(ingredientDto);

            _repository.Delete(ingredient);

            await _context.SaveChangesAsync();
        }
    }
}
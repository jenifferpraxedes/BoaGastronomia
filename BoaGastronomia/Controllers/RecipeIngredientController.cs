using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoaGastronomia.Controllers
{
    [Route("BoaGastronomia/[controller]")]
    [ApiController]
    public class RecipeIngredientController : ControllerBase
    {
        private readonly IRecipeIngredientService _service;

        public RecipeIngredientController(IRecipeIngredientService recipeIngredientService)
        {
            _service = recipeIngredientService;
        }

        [HttpGet]
        public List<RecipeIngredientDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public RecipeIngredientDto GetById(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public RecipeIngredientDto Save(RecipeIngredientDto recipeIngredientDto)
        {
            return _service.Save(recipeIngredientDto).Result;
        }

        [HttpDelete]
        public void Delete(RecipeIngredientDto recipeIngredientDto)
        {
            _service.Delete(recipeIngredientDto);
        }
    }
}
using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoaGastronomia.Controllers
{
    [Route("BoaGastronomia/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private readonly IRecipeService _service;

        public RecipeController(IRecipeService recipeService)
        {
            _service = recipeService;
        }

        [HttpGet]
        public List<RecipeDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public RecipeDto GetById(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public RecipeDto Save(RecipeDto recipeDto)
        {
            return _service.Save(recipeDto).Result;
        }

        [HttpDelete]
        public void Delete(RecipeDto recipeDto)
        {
            _service.Delete(recipeDto);
        }
    }
}
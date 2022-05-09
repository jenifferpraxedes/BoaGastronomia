using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoaGastronomia.Controllers
{
    [Route("BoaGastronomia/[controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private readonly IIngredientService _service;

        public IngredientController(IIngredientService ingredientService)
        {
            _service = ingredientService;
        }

        [HttpGet]
        public List<IngredientDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public IngredientDto GetById(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public IngredientDto Save(IngredientDto ingredientDto)
        {
            return _service.Save(ingredientDto).Result;
        }

        [HttpDelete]
        public void Delete(IngredientDto ingredientDto)
        {
            _service.Delete(ingredientDto);
        }
    }
}
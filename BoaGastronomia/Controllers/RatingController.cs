using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BoaGastronomia.Controllers
{
    [Route("BoaGastronomia/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IRatingService _service;

        public RatingController(IRatingService ratingtService)
        {
            _service = ratingtService;
        }

        [HttpGet]
        public List<RatingDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public RatingDto GetById(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public RatingDto Save(RatingDto ratingDto)
        {
            return _service.Save(ratingDto).Result;
        }

        [HttpDelete]
        public void Delete(RatingDto ratingDto)
        {
            _service.Delete(ratingDto);
        }
    }
}
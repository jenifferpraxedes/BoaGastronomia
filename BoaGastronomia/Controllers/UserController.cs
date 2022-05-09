using BoaGastronomia.Services.Mapping.Dtos;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoaGastronomia.Controllers
{
    [Route("BoaGastronomia/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _service;

        public UserController(IUserService userService)
        {
            _service = userService;
        }

        [HttpGet]
        public List<UserDto> GetAll()
        {
            return _service.GetAll().Result;
        }

        [HttpGet("{id}")]
        public UserDto GetById(int id)
        {
            return _service.GetById(id).Result;
        }

        [HttpPost]
        public UserDto Save(UserDto userDto)
        {
            return _service.Save(userDto).Result;
        }

        [HttpDelete]
        public void Delete(UserDto userDto)
        {
            _service.Delete(userDto);
        }
    }
}
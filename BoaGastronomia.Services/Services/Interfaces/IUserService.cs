using BoaGastronomia.Services.Mapping.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Interfaces
{
    public interface IUserService
    {
        public Task<List<UserDto>> GetAll();

        public Task<UserDto> GetById(int id);

        public Task<UserDto> Save(UserDto userDto);

        public Task Delete(UserDto userDto);
    }
}
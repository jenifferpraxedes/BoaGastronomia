using BoaGastronomia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Interfaces
{
    public interface IRatingRepository
    {
        Task<List<Rating>> GetAll();

        Task<Rating> GetById(int id);

        Rating Add(Rating rating);

        Rating Update(Rating rating);

        void Delete(Rating rating);
    }
}
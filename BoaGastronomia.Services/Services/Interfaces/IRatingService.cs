using BoaGastronomia.Services.Mapping.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Services.Services.Interfaces
{
    public interface IRatingService
    {
        public Task<List<RatingDto>> GetAll();

        public Task<RatingDto> GetById(int id);

        public Task<RatingDto> Save(RatingDto ratingDto);

        public Task Delete(RatingDto ratingDto);

        /*object GetById(IRatingService ratingService);
        object Save(RatingDto ratingDto);
        void Delete(RatingDto ratingDto);
        object GetAll();                                        <- PRECISO DISTO TUDO??   */
    }
}
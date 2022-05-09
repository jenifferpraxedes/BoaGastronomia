using BoaGastronomia.Domain.Entities;

namespace BoaGastronomia.Services.Mapping.Dtos
{
    public class RatingDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int UserId { get; set; }
        public int RatingValue { get; set; }
    }
}
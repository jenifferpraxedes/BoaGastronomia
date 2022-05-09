using BoaGastronomia.Domain.Entities;

namespace BoaGastronomia.Services.Mapping.Dtos
{
    public class RecipeIngredientDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int IngredientId { get; set; }
        public int Quantity { get; set; }
        public int Unity { get; set; }
    }
}
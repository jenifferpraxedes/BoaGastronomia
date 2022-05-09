namespace BoaGastronomia.Domain.Entities
{
    public class RecipeIngredient
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }

        public int Quantity { get; set; }
        public int Unity { get; set; }
    }
}
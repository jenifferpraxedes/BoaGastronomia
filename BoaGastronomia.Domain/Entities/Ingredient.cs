using System.Collections.Generic;

namespace BoaGastronomia.Domain.Entities
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<RecipeIngredient> RecipeIngredient { get; set; }

        //public object Name { get; set; }
    }
}
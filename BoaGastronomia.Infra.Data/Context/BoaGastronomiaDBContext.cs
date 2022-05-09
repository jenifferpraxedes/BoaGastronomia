using BoaGastronomia.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BoaGastronomia.Infra.Data.Context
{
    public class BoaGastronomiaDBContext : DbContext
    {
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }
        public DbSet<Rating> Ratings { get; set; }

        //public DbSet<UserPublic> UerPublics{ get; set; }  <- Preciso disto aqui?

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=JP\SQLEXPRESS;Database=BoaGastronomia;Trusted_connection=True");
        }
    }
}
using BoaGastronomia.Infra.Data.Context;
using BoaGastronomia.Infra.Data.Repositories.Implementations;
using BoaGastronomia.Infra.Data.Repositories.Interfaces;
using BoaGastronomia.Services.Mapping.AutoMapper;
using BoaGastronomia.Services.Services.Implementations;
using BoaGastronomia.Services.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BoaGastronomia.Infra.CrossCutting.DependencyContainer
{
    public static class DependencyContainer
    {
        public static void AddApiConfigurations(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<BoaGastronomiaDBContext>();
            services.AddAutoMapper(typeof(AutoMapperConfig));

            services.RegisterRepositories();
            services.RegisterServices();
        }

        private static void RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IRatingRepository, RatingRepository>();
            services.AddScoped<IRecipeIngredientRepository, RecipeIngredientRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
        }

        private static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IIngredientService, IngredientService>();
            services.AddScoped<IRatingService, RatingService>();
            services.AddScoped<IRecipeIngredientService, RecipeIngredientService>();
            services.AddScoped<IRecipeService, RecipeService>();
            services.AddScoped<IUserService, UserService>();
        }
    }
}
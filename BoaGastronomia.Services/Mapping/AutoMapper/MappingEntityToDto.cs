using AutoMapper;
using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Services.Mapping.Dtos;

namespace BoaGastronomia.Services.Mapping.AutoMapper
{
    public class MappingEntityToDto : Profile
    {
        public MappingEntityToDto()
        {
            CreateMap<Ingredient, IngredientDto>();
            CreateMap<Rating, RatingDto>();
            CreateMap<RecipeIngredient, RecipeIngredientDto>();
            CreateMap<Recipe, RecipeDto>();
            CreateMap<User, UserDto>();
            CreateMap<User, UserPublicDto>();
        }
    }
}
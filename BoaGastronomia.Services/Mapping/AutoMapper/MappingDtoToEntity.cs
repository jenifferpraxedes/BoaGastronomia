using AutoMapper;
using BoaGastronomia.Domain.Entities;
using BoaGastronomia.Services.Mapping.Dtos;

namespace BoaGastronomia.Services.Mapping.AutoMapper
{
    public class MappingDtoToEntity : Profile
    {
        public MappingDtoToEntity()
        {
            CreateMap<IngredientDto, Ingredient>();//.ForMember(dest => dest.RatingId, opt => opt.Ignore());  "Não sei se o Rating seria a classe certa a ignorar"
            CreateMap<RatingDto, Rating>();
            CreateMap<RecipeIngredientDto, RecipeIngredient>();
            CreateMap<RecipeDto, Recipe>();
            CreateMap<UserDto, User>();
            CreateMap<UserPublicDto, User>();
        }
    }
}
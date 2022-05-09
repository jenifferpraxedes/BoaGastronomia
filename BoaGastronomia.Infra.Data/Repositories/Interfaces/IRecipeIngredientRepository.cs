﻿using BoaGastronomia.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BoaGastronomia.Infra.Data.Repositories.Interfaces
{
    public interface IRecipeIngredientRepository
    {
        Task<List<RecipeIngredient>> GetAll();

        Task<RecipeIngredient> GetById(int id);

        RecipeIngredient Add(RecipeIngredient recipeIngredient);

        RecipeIngredient Update(RecipeIngredient recipeIngredient);

        void Delete(RecipeIngredient recipeIngredient);
    }
}
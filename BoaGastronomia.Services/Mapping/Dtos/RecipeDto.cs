using BoaGastronomia.Domain.Entities;
using System;
using System.Collections.Generic;

namespace BoaGastronomia.Services.Mapping.Dtos
{
    public class RecipeDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime ExecutionTime { get; set; }
        public int Difficulty { get; set; }
    }
}
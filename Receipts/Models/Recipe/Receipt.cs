using System.Collections.Generic;
using ApplicationCore.Entities;

namespace Models
{
    public class Receipt : BaseEntity
    {
        public string Name{get; set ;}
        public string Description { get; set; }
        public List<IngredientRecipe> Ingredients { get; set; }
        public List<StepRecipe> Steps { get; set; }

        public Receipt()
        {
            Ingredients = new List<IngredientRecipe>();
            Steps = new List<StepRecipe>();
        }
    }
}



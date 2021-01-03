using System;
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
        public string ImageUrl { get; set; }

        public Receipt()
        {
            Ingredients = new List<IngredientRecipe>();
            Steps = new List<StepRecipe>();
        }

        public Receipt(List<IngredientRecipe> ingredientsRecipies,
        List<StepRecipe> stepRecipies,
        string name,
        string description,
        string imageUrl)
        {
            Ingredients = new List<IngredientRecipe>();
            Steps = new List<StepRecipe>();
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            foreach(IngredientRecipe ingredient in ingredientsRecipies)
            {
                AddIngredient(ingredient);
            }
            foreach(StepRecipe step in stepRecipies)
            {
                AddStep(step);
            }
            ImageUrl = imageUrl;
            CreatedDate = DateTime.Now;
        }

        public void AddIngredient(IngredientRecipe ingredient)
        {
            ingredient.Receipt = this;
            Ingredients.Add(ingredient);
        }

        public void AddStep(StepRecipe step)
        {
            step.Receipt = this;
            Steps.Add(step);
        }
    }
}



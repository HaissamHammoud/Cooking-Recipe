using System;
using System.Collections.Generic;
using ApplicationCore.Entities;

namespace Models
{
    public class Recipe : BaseEntity
    {
        public string Name{get; set ;}
        public string Description { get; set; }
        public List<IngredientRecipe> Ingredients { get; set; }
        public List<StepRecipe> Steps { get; set; }
        public string ImageUrl { get; set; }

        public Recipe()
        {
            Ingredients = new List<IngredientRecipe>();
            Steps = new List<StepRecipe>();
        }

        public Recipe(
            List<IngredientRecipe> ingredientsRecipies,
            List<StepRecipe> stepRecipies,
            string name,
            string description,
            string imageUrl
        )
        {
            if(ingredientsRecipies.Count == 0 || stepRecipies.Count == 0)
            {
                throw new Exception("No steps and ingredients was given");
            }
            if(string.IsNullOrEmpty(name))
            {
                throw new Exception("No name was given");
            }
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
            ingredient.Recipe = this;
            Ingredients.Add(ingredient);
        }

        public void AddStep(StepRecipe step)
        {
            step.Recipe = this;
            Steps.Add(step);
        }
    }
}



using System;
using ApplicationCore.Entities;

namespace Models
{
    public class StepRecipe : BaseEntity
    {
        public string Step { get; set; }
        public int StepNumber { get; set; }
        public virtual Recipe Recipe { get; set; }
        public Guid RecipeId { get; set; }

        public StepRecipe()
        {
            Id = Guid.NewGuid();
        }
    }
}


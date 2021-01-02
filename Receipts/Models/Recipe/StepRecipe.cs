using ApplicationCore.Entities;

namespace Models
{
    public class StepRecipe : BaseEntity
    {
        public string Step { get; set; }
        public int RecipeId { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}


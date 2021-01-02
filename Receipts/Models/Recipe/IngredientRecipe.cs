using ApplicationCore.Entities;

namespace Models
{
    public class IngredientRecipe : BaseEntity
    {
        public string Quantity { get; set; }
        public string Ingredient { get; set; }
        public int RecipeId { get; set; }
        public virtual Receipt Receipt { get; set; }
    }
}



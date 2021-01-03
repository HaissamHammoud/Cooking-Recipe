using System;
using ApplicationCore.Entities;

namespace Models
{
    public class IngredientRecipe : BaseEntity
    {
        public string Quantity { get; set; }
        public string Ingredient { get; set; }
        public virtual Receipt Receipt { get; set; }
        public Guid ReceiptId { get; set; }

        public IngredientRecipe()
        {
            Id = Guid.NewGuid();
        }
    }
}



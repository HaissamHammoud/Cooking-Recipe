using System;
using ApplicationCore.Entities;

namespace Models
{
    public class StepRecipe : BaseEntity
    {
        public string Step { get; set; }
        public int StepNumber { get; set; }
        public virtual Receipt Receipt { get; set; }
        public Guid ReceiptId { get; set; }

        public StepRecipe()
        {
            Id = Guid.NewGuid();
        }
    }
}


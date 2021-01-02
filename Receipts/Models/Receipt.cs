using System.ComponentModel.DataAnnotations.Schema;
using ApplicationCore.Entities;

namespace Models
{
    public class Receipt : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name{get; set ;}
        public string Ingredients { get; set; }
        public string Steps { get; set; }
    }
}



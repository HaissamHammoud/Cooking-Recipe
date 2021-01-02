using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class Receipt
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name{get; set ;}
        public string Ingredients { get; set; }
        public string Steps { get; set; }
    }
}



using System.ComponentModel.DataAnnotations;

namespace Day8.Model
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30,ErrorMessage ="Too longe name")]
        public string Name { get; set; }

        public decimal Price { get; set; }
    }
}

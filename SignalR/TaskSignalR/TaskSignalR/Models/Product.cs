using System.ComponentModel.DataAnnotations;

namespace TaskSignalR.Models
{
    public class Product
    {
        [Key]
        public int id { get; set; }

        public required string Name { get; set; }
        public required decimal Price { get; set; }
        public required int Quantity { get; set; }
        public required string Image { get; set; }

        public virtual ICollection<Comment?> Comments { get; set; } = new HashSet<Comment?>();

    }
}

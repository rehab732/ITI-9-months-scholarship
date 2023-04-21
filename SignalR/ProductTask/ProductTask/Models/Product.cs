using System.ComponentModel.DataAnnotations;

namespace ProductTask.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public required string Name { get; set; }
		public int Price { get; set; }
		public int Quantity { get; set; }
		public required string Image { get; set; }

		public virtual ICollection<Comment?> Comments { get; set; } = new HashSet<Comment?>();


	}
}

using System.ComponentModel.DataAnnotations.Schema;

namespace ProductTask.Models
{
	public class Comment
	{

		public int Id { get; set; }
		public required string Text { get; set; }
		public required string CallerName { get; set; }

		[ForeignKey("Product")]
		public int ProductId { get; set; }
		public virtual Product? Product { get; set; }
	}
}

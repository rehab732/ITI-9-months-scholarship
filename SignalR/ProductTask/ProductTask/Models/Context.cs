using Microsoft.EntityFrameworkCore;

namespace ProductTask.Models
{
	public class Context:DbContext
	{
		public Context(DbContextOptions<Context> options) : base(options)
		{ }
		public virtual DbSet<Product> Products { get; set; }
		public virtual DbSet<Comment> Comments { get; set; }
	}
}

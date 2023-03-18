using Microsoft.EntityFrameworkCore;
using Microsoft.SqlServer;
namespace Day8.Model
{
	public class ProductDBcontext:DbContext
	{
		public ProductDBcontext(DbContextOptions<ProductDBcontext> options) : base(options)
			{

		}

		public DbSet<Product> Products { get; set; }

	}
}

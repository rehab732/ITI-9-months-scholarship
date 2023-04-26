using Microsoft.EntityFrameworkCore;

namespace TaskSignalR.Models
{
    public class Context:DbContext
    {
        public Context( DbContextOptions<Context> opt ):base( opt )
        {

        }

        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
    }
}

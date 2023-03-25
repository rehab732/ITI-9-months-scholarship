using Microsoft.EntityFrameworkCore;

namespace Test.Models
{
    public class DepContext:DbContext
    {
        public DepContext()
        {
            //for create my owne object
        }
        public DepContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
    }
}

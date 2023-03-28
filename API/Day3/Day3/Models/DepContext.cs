using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Day3.Models
{
    public class DepContext : IdentityDbContext<ApplicationUser>
    {
        public DepContext()
        {
            //for create my owne object
        }
        public DepContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}

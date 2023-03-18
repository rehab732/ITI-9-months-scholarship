using Microsoft.EntityFrameworkCore;

namespace Task1.Model
{
    public class StudentCourceContext:DbContext
    {
        //Reuest Service of type studentcourcecontext
        public StudentCourceContext(DbContextOptions<StudentCourceContext>options):base(options) 
        {
            
        }

        public DbSet<Student> Students { get;set; }
        public DbSet<Course> Courses { get;set; }


    }
}

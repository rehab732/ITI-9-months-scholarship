using Day2_3.DataAccess;
using Day2_3.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_3.DataService
{
    public class StudentDataService : IDataService
    {
        public IEnumerable<Student> GetAllStudents()
        {
            using (SchoolDBContext context = new())
            {
                context.Database.EnsureCreated();
                return context.Students.ToList();
            }
        }
    }
}

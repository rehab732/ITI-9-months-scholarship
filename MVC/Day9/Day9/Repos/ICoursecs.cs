using System.Collections.Generic;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public interface ICoursecs
    {
        public List<Course> GetAll();
        public Course GetCourse(int id);
        public void InsertCourse(Course Course);
        public void UpdateCourse(int id, Course Course);
        public void DeleteCourse(int id);
    }
}

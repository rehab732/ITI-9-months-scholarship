using System.Collections.Generic;
using System.Linq;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Repos
{
    public class CourseReo : ICoursecs
    {
        public ApplicationDbContext Context { get; set; }
        public CourseReo(ApplicationDbContext context)
        {
            Context = context;
        }
        public void DeleteCourse(int id)
        {
            Course course = Context.Courses.Find(id);
            Context.Courses.Remove(course);
            Context.SaveChanges();
        }

        public List<Course> GetAll()
        {
            return Context.Courses.ToList();
        }

        public Course GetCourse(int id)
        {
            Course course = Context.Courses.Find(id);
            return course == null ? null : course;
        }

        public void InsertCourse(Course Course)
        {
            Context.Courses.Add(Course);
            Context.SaveChanges();
        }

        public void UpdateCourse(int id, Course Course)
        {
            Course course = Context.Courses.Find(id);
            course.Topic = Course.Topic;
            course.TraineeID = Course.TraineeID;
            course.Grade= Course.Grade;
            Context.SaveChanges();
        }
    }
}

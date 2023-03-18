using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Task1.Model
{
    public class Course
    {
        /*
         * - ID
            - Topic
            - CourseGrade
         */

        [Key]
        public int Id { get; set; }
        [Required]
        public string Topic { get; set; } = string.Empty;
        [Required]
        public int CourseGrade { get; set; }

        public virtual ICollection<Student> Students { get; }=new List<Student>();


    }
}

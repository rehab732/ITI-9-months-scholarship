using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Course
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "This field is required")]
        public Topic Topic { get; set; }


        [Required(ErrorMessage = "This field is required")]

        [Range(0, 100, ErrorMessage = "Exceed Rahge from 0 to 100")]

        public int Grade { get; set; }
        [ForeignKey("Trainee")]
        public int TraineeID { get; set; }
        public virtual Trainee Trainee { get; set; }
    }


    public enum Topic { MVC, OOP, C, AI, MOBILE, JAVA, PYTHON };

}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Trainee
    {
        public int ID { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "This field is required")]

        public string Name { get; set; }
        [Required(ErrorMessage = "This field is required")]

        public Gender Gender { get; set; }
        [Required(ErrorMessage = "This field is required")]

        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [MaxLength(11)]
        public string MobileNo { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DataType(dataType: DataType.Date)]
        public DateTime Birthdate { get; set; }

        [ForeignKey("Track")]
        public int TrackID { get; set; }
        public virtual Track track { get; set; }

        public List<Course> Courses { get; set; } = new List<Course>();

    }
    public enum Gender { Male, Female }
}

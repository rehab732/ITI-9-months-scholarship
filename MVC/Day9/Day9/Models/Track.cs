using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "This field is required")]

        public string Name { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "This field is required")]

        public string Description { get; set; }
        public virtual List<Trainee> Trainees { get; set; }
    }
}

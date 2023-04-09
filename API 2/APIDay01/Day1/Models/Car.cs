using Day1.Validators;
using System.ComponentModel.DataAnnotations;

namespace Day1.Models
{
    public class Car
    { 
        public int Id { get; set; }
        [StringLength(50,MinimumLength =10,ErrorMessage ="Car Name Must Be Between {2} and {1}")]
        public string Name { get; set; } = string.Empty;

        [StringLength(50, MinimumLength = 10, ErrorMessage = "Car Model Must Be Between {2} and {1}")]
        public string Model { get; set; } = string.Empty;
        public double Price { get; set; }

        [DateInPast]
        public DateTime ProductionDate { get; set; }
        public string CarType { get; set; } = string.Empty;
        public Car(int id, string name, string model, double price, DateTime productionDate,string cartype)
        {
            Id = id;
            Name = name;
            Model = model;
            Price = price;
            ProductionDate = productionDate;
            CarType = cartype;
        }

    }
}

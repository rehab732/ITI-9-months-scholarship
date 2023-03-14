using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Day7.Model
{
    public class CarList 
    {
        public static List<Car> cars = new List<Car>()
        {
         new Car (){ Num = 1, Model = "Civic", Manfacture = "Honda", Color = "Blue" },
         new Car (){ Num = 2, Model = "Corolla", Manfacture = "Toyota", Color = "Black" },
         new Car (){ Num = 3, Model = "Mustang", Manfacture = "Ford", Color = "Red" },
         new Car (){ Num = 4, Model = "Prius", Manfacture = "Toyota", Color = "Yello" },
         new Car (){ Num = 5, Model = "Camry", Manfacture = "Honda", Color = "Green" },
         new Car (){ Num = 6, Model = "Rav4", Manfacture = "Ford", Color = "Black" },
         new Car (){ Num = 7, Model = "Civic", Manfacture = "Honda", Color = "Green" },
         new Car (){ Num = 8, Model = "Civic", Manfacture = "Toyota", Color = "Green" },
         new Car (){ Num = 9, Model = "Escape", Manfacture = "Honda", Color = "Blue" },
         new Car (){ Num = 10, Model = "Accord", Manfacture = "Ford", Color = "Red" },


        };
    }
}

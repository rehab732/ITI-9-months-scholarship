using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using WPFCar.Commands;
using WPFCar.Model;

namespace WPFCar.ViewModel
{
    public class CarViewModel
    {
        public ObservableCollection<Car> CarList { get; set; }
        public ICommand AddCommand { get; set; }
        public Car Newcar { get; set; }
        public CarViewModel()
        {
            AddCommand = new CarCommand(Add,CanAdd);
            Newcar = new();
            CarList = new ObservableCollection<Car>()
            {
                    new () { Id = 1, Price = 10000, Name = "Car 1", Model = 2022, Color = "Red" },
                    new () { Id = 2, Price = 20000, Name = "Car 2", Model = 2023, Color = "Blue" },
                    new () { Id = 3, Price = 30000, Name = "Car 3", Model = 2024, Color = "Green" },
                    new () { Id = 4, Price = 40000, Name = "Car 4", Model = 2025, Color = "Yellow" },
                    new () { Id = 5, Price = 50000, Name = "Car 5", Model = 2026, Color = "Orange" },
                    new () { Id = 6, Price = 60000, Name = "Car 6", Model = 2027, Color = "Purple" },
                    new () { Id = 7, Price = 70000, Name = "Car 7", Model = 2028, Color = "Black" },
                    new () { Id = 8, Price = 80000, Name = "Car 8", Model = 2029, Color = "White" },
                    new () { Id = 9, Price = 90000, Name = "Car 9", Model = 2030, Color = "Gray" },

            };

        }

        private bool CanAdd(object obj)
        {
            return true;
        }

        private void Add(object obj)
        {
            Car newcar = obj as Car;
            var o = new Car();
            o.Name = newcar.Name;
            o.Color = newcar.Color;
            o.Id=newcar.Id;
            o.Model=newcar.Model;
            o.Price= newcar.Price;
            CarList.Add(o);
            MessageBox.Show("Added");
        }
    }
}

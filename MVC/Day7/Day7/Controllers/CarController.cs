using Day7.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Day7.Controllers
{
    public class CarController : Controller
    {
        // GET: Employee
        public ActionResult GetAllCars()
        {
            List<Car> carslist = CarList.cars;
            //step1 need to add view
            //step2 pass data from controller to view by(viewdata or viewbag)
            //let use viewbag
            ViewBag.cars = carslist;//shared with me in view

            return View();
        }
        public ActionResult SelectCarByID(int id)
        {

            Car selectedcar = CarList.cars.FirstOrDefault(c => c.Num == id);
            ViewBag.selectedcar = selectedcar;

            return View();
        }
        public ActionResult DeleteCarByID(int id)
        {

            var deleted = CarList.cars.FirstOrDefault(c => c.Num == id);
            CarList.cars.Remove(deleted);

            return RedirectToAction("GetAllCars");
        }
        public ActionResult EditCarByID(int id)
        {
            var editcar = CarList.cars.FirstOrDefault(c => c.Num == id);
            ViewBag.edit = editcar;
            return View();
        }
        public ActionResult SaveCarData(int id, string model, string color, string manfacture)
        {
            Car saveCar = CarList.cars.FirstOrDefault(c => c.Num == id);
            saveCar.Model = model;
            saveCar.Color = color;
            saveCar.Manfacture = manfacture;
            return RedirectToAction("GetAllCars");
        }
        public ActionResult CreateNewCar()
        {
            Car car = new Car();
            ViewBag.create = car;
            return View();

        }

        [HttpPost]
        public ActionResult CreateNewCar(int id, string model, string color, string manfacture)
        {
            Car cartest = new Car();
            cartest.Num = id;
            cartest.Model = model;
            cartest.Color = color;
            cartest.Manfacture = manfacture;

            //CarList.cars.Insert(id, cartest);


            CarList.cars.Add(cartest);

            return RedirectToAction("GetAllCars");

        }
    }
}

using Day1.Filters;
using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        public CarsController(ILogger<CarsController> logger)
        {
            _logger= logger;
        }
        public static List<Car> _cars = new List<Car>
        {
                new (1,"bjkj","nlkn",4544,new DateTime(2021, 3, 22),"Gas"),
                new (2,"ankax","smal",4544,new DateTime(2021, 3, 22),"Gas"),
                new (3,"ssak","cskln",4544,new DateTime(2021, 3, 22), "Gas"),
                new (4,"salsx","sano",4544,new DateTime(2021, 3, 22), "Gas"),
                new (5,"sla","aUsigi",4544,new DateTime(2021, 3, 22), "Gas"),
        };
        [HttpGet]
        public ActionResult<List<Car>> GetAll()
        {
            _logger.LogCritical("get all request");
            if (!_cars.Any())
            {
                return NotFound();
            }
            
            return Ok(_cars);
        }

        [HttpGet]
        [Route("{id}")] 
        public ActionResult<Car> GetById(int id)
        {
            Car? car = _cars.FirstOrDefault(m => m.Id == id);
            if (car == null)
            {
                return NotFound();//404 not found
            }
            return car; //200 and json 

        }

        [HttpPost]
        [Route("V1")]
        [ValidateCarType]
        public ActionResult AddV2(Car car)
        {
            car.Id = new Random().Next(10, 1000);
            _cars.Add(car);
            car.CarType = "Gas";
            return CreatedAtAction(//created 201
                actionName: "GetById",
                routeValues: new { id = car.Id },
                value: new { Message = "Car Created Successfully" }//response body
            );
        }

        [HttpPost]
        [Route("V2")]
        public ActionResult Add(Car car)
        {
            car.Id = new Random().Next(10, 1000);
            _cars.Add(car);
            return CreatedAtAction(//created 201
                actionName: "GetById",
                routeValues: new { id = car.Id },
                value: new { Message = "Car Created Successfully" }//response body
            );
        }



        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(Car car, int id)
        {
            if (id != car.Id)
            {
                return BadRequest();
            }
            var carToUpdate = _cars.FirstOrDefault(m => m.Id == id);
            if (carToUpdate is null)
            {
                return NotFound();
            }
            carToUpdate.Name = car.Name;
            carToUpdate.Price = car.Price;
            carToUpdate.Model = car.Model;
            carToUpdate.CarType =car.CarType;
            return NoContent();//204 success
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var car = _cars.FirstOrDefault(m => m.Id == id);
            if (car is null)
            {
                return NotFound();
            }
            _cars.Remove(car);
            return NoContent();
        }

    }
}

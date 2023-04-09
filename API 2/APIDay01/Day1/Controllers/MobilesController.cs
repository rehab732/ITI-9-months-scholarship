using Day1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobilesController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<Mobile>> GetAll()
        {
            if(!Mobile._mobiles.Any())
            {
                return NotFound();
            }
            //return Mobile._mobiles; valid 
            //OR
            return Ok(Mobile._mobiles);
        }

        [HttpGet]
        [Route("{id}")] /// api/Mobile/id
        public ActionResult <Mobile> GetById(int id) {
            Mobile? mobile=Mobile._mobiles.FirstOrDefault(m => m.Id == id);
            if(mobile==null)
            {
                return NotFound();//404 not found
            }
            return mobile; //200 and json 
           
        }

        [HttpPost]
        public ActionResult Add(Mobile mobile)
        {
            mobile.Id = new Random().Next(10, 1000);
            Mobile._mobiles.Add(mobile);
            return CreatedAtAction(//created 201
                actionName: "GetById",
                routeValues: new { id = mobile.Id },
                value: new { Message = "Mobile Created Successfully"}//response body
            );
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult Update(Mobile mobile,int id)
        {
            if(id != mobile.Id)
            {
                return BadRequest();
            }
            var mobileToUpdate = Mobile._mobiles.FirstOrDefault(m => m.Id == id);
            if(mobileToUpdate is null)
            {
                return NotFound();
            }
            mobileToUpdate.Name = mobile.Name;
            mobileToUpdate.Price = mobile.Price;
            mobileToUpdate.Model = mobile.Model;
            return NoContent();//204 success
        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult Delete(int id)
        {
            var mobile = Mobile._mobiles.FirstOrDefault(m => m.Id == id);
            if(mobile is null )
            {
                return NotFound();
            }
            Mobile._mobiles.Remove(mobile);
            return NoContent();
        }
    }
}

using Day1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Day1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourceController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            if(Course.Cources.Any()) return Ok(Course.Cources);
            return NotFound();
        }
        [HttpDelete]
        public IActionResult DeleteCource(int id)
        {
            /* If i return Cource List
            Course c = Course.Cources.Find(co=>co.Id==id);
            Course.Cources.Remove(c);
            return Course.Cources.ToList();*/
            var cource = Course.Cources.Where(co=>co.Id==id).FirstOrDefault();
            if(cource==null) return NotFound();
            Course.Cources.Remove(cource);
            return Ok(Course.Cources);

        }


        [HttpPut]
        public IActionResult Put(int id, Course course)
        {
            if(id!=course.Id) return BadRequest();
            var c = Course.Cources.Where(c=>c.Id==id).FirstOrDefault(); 
            if(c==null) return NotFound();
            Course.Cources.Remove(c);
            Course.Cources.Add(course);
            return NoContent();
        }

        [HttpPost]
        public IActionResult Post(Course course)
        {
            var c = Course.Cources.Where(c => c.Id == course.Id).FirstOrDefault();
            if(course==null||c!=null) return BadRequest();
            Course.Cources.Add(course);
            return Created($"/GetById/{course.Id}", course);
        }
        [HttpGet("{id:int}")]
        public IActionResult GetById(int id)
        {
            var c = Course.Cources.Where(c => c.Id == id).FirstOrDefault();
            if(c==null) return NotFound();  
            return Ok(c);

        }
        [HttpGet("{name:alpha}")]
        public IActionResult CourcseByName(string name)
        {
            var c = Course.Cources.Where(c => c.Name.ToLower() == name.ToLower()).FirstOrDefault();
            if (c == null) return NotFound();
            return Ok(c);

        }
    }
}

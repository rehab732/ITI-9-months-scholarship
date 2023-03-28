using Day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        public readonly DepContext Context;
        public DepartmentController(DepContext context)
        {
            this.Context = context;
        }

        //Actions
        [HttpGet]//api/Department
        public IActionResult GetAllDepartment()
        {
            List<Department> deplist = Context.Departments.ToList();
            return Ok(deplist);//response body

        }
        [HttpGet("{id:int}", Name = "GetOnedep")]
        // [Route("{id:int}")]//api/Department/5
        public IActionResult GetDepartmentById(int id)
        {
            Department b = Context.Departments.FirstOrDefault(d => d.Id == id);
            return Ok(b);

        }
        [HttpGet("Emps/{id:int}")]
        // [Route("{id:int}")]//api/Department/5
        public IActionResult GetDepartmentByIdDTO(int id)
        {
            Department b = Context.Departments.Include(s => s.Employee).FirstOrDefault(d => d.Id == id);
            DepartmentwithEmployeeDTO depdto = new DepartmentwithEmployeeDTO();
            depdto.Id = id;
            depdto.DeptName = b.Name;
            foreach (var item in b.Employee)
            {
                depdto.EmployeesNames.Add(item.Name);
            }
            return Ok(depdto);

        }
        [HttpGet]
        [Route("{name:alpha}")]//api/Department/Rehab
        public IActionResult GetDepartmentByName(string name)
        {
            Department b = Context.Departments.FirstOrDefault(d => d.Name == name);
            return Ok(b);

        }

        [HttpPost]//api/Department
        public IActionResult PostAllDepartment(Department dep)//request body
        {
            if (ModelState.IsValid == true)
            {
                Context.Add(dep);
                Context.SaveChanges();
                string url = Url.Link("GetOnedep", new { id = dep.Id });
                return Created(url, dep);
                //return Ok("Dep Saved Successfully");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        [HttpPut("{id}")]//api/Department
        public IActionResult Update([FromRoute] int id, [FromBody] Department dep)
        {
            if (ModelState.IsValid == true)
            {
                Department oldd = Context.Departments.FirstOrDefault(d => d.Id == id);
                oldd.Name = dep.Name;
                oldd.Manager = dep.Manager;
                Context.SaveChanges();
                return StatusCode(204, "Data Changed");

            }
            else
            {
                return BadRequest(ModelState);
            }

        }
        [HttpDelete("{id:int}")]//api/Department
        public IActionResult Remove(int id)
        {
            Department dep = Context.Departments.FirstOrDefault(d => d.Id == id);
            if (dep != null)
            {
                try
                {
                    Context.Departments.Remove(dep);
                    Context.SaveChanges();
                    return StatusCode(204, "Removed");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }

            }

            return BadRequest("Can't Remove Department");



        }
    }
}

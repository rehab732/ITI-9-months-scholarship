using Day3.DTO;
using Day3.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Day3.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public readonly DepContext Context;
        public EmployeeController(DepContext context)
        {
            this.Context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Employee> emplist = Context.Employees.Include(s => s.dept).ToList();//cycle zeft 
            return Ok(emplist);

        }
        [HttpGet("{id:int}", Name = "OneEmployeeRoute")]
        public IActionResult GetOne(int id)
        {
            Employee emp = Context.Employees.Include(s => s.dept).FirstOrDefault(e => e.Id == id);//cycle zeft 

            EmployeeDepartmentDTO epmdto = new EmployeeDepartmentDTO();
            epmdto.DepartmentName = emp.dept.Name;
            epmdto.Id = emp.Id;
            epmdto.StudentName = emp.Name;
            epmdto.Address = emp.Address;
            return Ok(epmdto);

        }
    }
}

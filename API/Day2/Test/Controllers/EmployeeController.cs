using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Test.Models;
using Microsoft.EntityFrameworkCore;
using Test.DTO;
namespace Test.Controllers
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
        [HttpGet("{id:int}",Name ="OneEmployeeRoute")]
        public IActionResult GetOne(int id)
        {
            Employee emp = Context.Employees.Include(s => s.dept).FirstOrDefault(e => e.Id == id);//cycle zeft 

            EmployeeDepartmentDTO epmdto= new EmployeeDepartmentDTO();
            epmdto.DepartmentName = emp.dept.Name;
            epmdto.Id= emp.Id;
            epmdto.StudentName = emp.Name;
            epmdto.Address = emp.Address;
            return Ok(epmdto);

        }
    }
}

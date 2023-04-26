using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Task1.Hubs;
using Task1.Models;

namespace Task1.Controllers
{
    public class EmployeeController : Controller
    {
        List<Employee> employees;

		public IHubContext<EmployeeHub> EmpHub { get; }

		public EmployeeController(IHubContext<EmployeeHub> empHub)//inject service
        {
            employees = new List<Employee>();
            employees.Add(new Employee() { Id = 1, Name = "Ra7oba", Salary = 25000 });
            employees.Add(new Employee() { Id = 2, Name = "Ra7oba", Salary = 25000 });
            employees.Add(new Employee() { Id = 3, Name = "Ra7oba", Salary = 25000 });
            employees.Add(new Employee() { Id = 4, Name = "Ra7oba", Salary = 25000 });
			EmpHub = empHub;
		}
			public IActionResult Index()
            {
                return View();
            }
        public IActionResult ShowAllEmployees()
        {
            return View(employees);
        }
        [HttpGet]
        public IActionResult AddEmployee() {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee newEmp)
        {
            employees.Add(newEmp);
            //need to call hub here outside hubcontext
            EmpHub.Clients.All.SendAsync("NotifyNewEmployee", newEmp);
            return View();
        }
    }
}

using System.Collections.Generic;

namespace Day3.DTO
{
    public class DepartmentwithEmployeeDTO
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public List<string> EmployeesNames { get; set; }= new List<string>();
    }

}

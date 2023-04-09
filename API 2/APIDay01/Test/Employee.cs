using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class Employee
    {
        public int Id { get; init; }
        public string Name { get; init; }
        public Employee( int id,string name) { 
            Id = id;
            Name = name;
        }   
    }


    public record EmployeeRec(int id, string name);
}

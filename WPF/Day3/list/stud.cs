using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace list
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? Salary { get; set; }
        public string? Image { get; set; } 
        public override string  ToString()
        {
            return $" Student Name : {Name}";

        }
    }
}

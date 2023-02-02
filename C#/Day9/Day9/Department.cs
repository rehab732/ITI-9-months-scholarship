using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    public class Department
    {
        public int DeptID { get; set; }
        public string DeptName { get; set; }
        List<Employee> Staff;

        public Department()
        {
            Staff = new List<Employee>();
        }
        public void AddStaff (Employee E)
        {
            if(E != null)
            {
                Staff.Add(E);
                E.EmployeeLayOff += RemoveStaff;
            }
            
        }
        ///CallBackMethod 
        //sender==publisher
        public void RemoveStaff(object sender, EmployeeLayoutEventArgs e)
        {
            if (sender is Employee emp)
                Console.WriteLine($"Employee Numer {emp.EmployeeID}  removed from Department {DeptName} staff for this Cause {e.Cause}");
        }
    }
}

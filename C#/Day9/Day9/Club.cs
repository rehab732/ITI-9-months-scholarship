using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day9.EmployeeLayoutEventArgs;

namespace Day9
{
    public class Club
    {


        
            public int ClubID { get; set; }
            public String ClubName { get; set; }
            List<Employee> Members;


            public Club()
            {
                Members = new List<Employee>();
            }
            public void AddMember(Employee E)
            {
            ///Try Register for EmployeeLayOff Event Here
            if(E != null)
                {
                    Members.Add(E);

                if (E is not BoardMember)
                {
                    E.EmployeeLayOff += RemoveMember;
                }
            }

            }


            ///CallBackMethod
            public void RemoveMember(object sender, EmployeeLayoutEventArgs e)
        {
            ///Employee Will not be removed from the Club if Age > 60
            ///Employee will be removed from Club if Vacation Stock < 0

            if (sender is Employee emp && e.Cause != LayOffCause.Age)
                Console.WriteLine($"Employee Number {emp.EmployeeID}  removed from club {ClubName} members for {e.Cause}");
        }
    }
}

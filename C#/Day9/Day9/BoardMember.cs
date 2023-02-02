using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day9.EmployeeLayoutEventArgs;

namespace Day9
{
    public class BoardMember : Employee
    {
        public void Resign()
        {
            OnEmployeeLayOff(new() { Cause = LayOffCause.Resign });

        }
        protected override void OnEmployeeLayOff(EmployeeLayoutEventArgs e)
        {
            if (e.Cause == LayOffCause.Resign)
                base.OnEmployeeLayOff(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Day9.EmployeeLayoutEventArgs;

namespace Day9
{
    public class SalesPerson : Employee
    {
        public int AchievedTarget { get; set; }
        public bool CheckTarget(int Quota)
        {

            if (AchievedTarget >= Quota) return true;

            OnEmployeeLayOff(new() { Cause = LayOffCause.BelowTarget });
            return false;
        }

        //layoff lama ykoon below target or age>60
        protected override void OnEmployeeLayOff(EmployeeLayoutEventArgs e)
        {
            if (e.Cause == LayOffCause.BelowTarget || e.Cause == LayOffCause.Age)
                base.OnEmployeeLayOff(e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day9
{
    //contain any additional info need to pass to subs
    public class EmployeeLayoutEventArgs:EventArgs
    {
        public enum LayOffCause
        //Age
        //Vacation Stock
        //استقالة 
        //below target 
        {
            ExcessVacation = 0, Age = 1, BelowTarget = 2, Resign = 3
        }
        public LayOffCause Cause { get; set; }

    }
}

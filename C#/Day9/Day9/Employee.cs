using System;
using static Day9.EmployeeLayoutEventArgs;

namespace Day9
{
    //publisher
    //Company will Lay off All Type of Employees in Two Cases
    //If Employee Vacation Stock< 0
    //If Employee Age > 60
    public class Employee
    {
        //step 1 declare event 
        public event EventHandler<EmployeeLayoutEventArgs> EmployeeLayOff;
        //step 2 event function 
        protected virtual void OnEmployeeLayOff(EmployeeLayoutEventArgs e)
        {
            //notify subs 
            EmployeeLayOff?.Invoke(this, e);

        }
        public int EmployeeID { get; set; }
        public DateTime BirthDate
        {
            get;
            init;
        }
        public int vacationStok;
        public int VacationStock
        {
            get { return vacationStok; }
            init { vacationStok = value; }
        }

        //first Cause for layoff
        //if vacation stock<0
        public bool RequestVacation(DateTime From, DateTime To)
        {
            int vacation_days=(int) (To- From).TotalDays ;
            vacationStok -=vacation_days;
            if(vacationStok< 0)
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.ExcessVacation });
                return true;
            }
            return false;
        }
        //second Cause for layoff
        //if age >60

        public void EndOfYearOperation()
        {
            double age = (DateTime.Now - BirthDate).TotalDays / 365;
            if(age>60)
            {
                OnEmployeeLayOff(new() { Cause = LayOffCause.Age });

            }
        }
    }
   

}


internal partial class Program
{
    public struct Employee
    {
        string name;
        int id;
        Hiredate hiredate;
        Security security;
        Gender gender;
        decimal salary;
      

        //All properties
        public int Id
        {
            get { return this.id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }   
            set { this.name = value; }
        }
        public decimal Salary
        {
            get { return this.salary; } 
            set { this.salary = value; }

        }
        public Hiredate Hiredate
        {
            get { return this.hiredate;}
            set { this.hiredate = value;}

        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }

        }
        public Security Security
        {
            get { return this.security; }
            set { this.security = value; }
        }

       
        
        //override tostring 
        public override string ToString()
        {
            return $"Name:{Name} \n" +
                $"Id: {Id} \n" +
                $"Salary:{Salary} \n" +
                $"Hiredate:{Hiredate} \n" +
                $"Security:{Security}\n" +
                $"Gender:{Gender}\n";
        }


    }
}
namespace FirstAppDay2
{
    struct Employee
    {
        String Name;
        int id;
        int salary;
        Hiredate hiredate;
        Gender gender;
        Security security;

        public Employee(string name, int id, int salary, Hiredate hiredate, Gender gender, Security security)
        {
            Name = name;
            this.id = id;
            this.salary = salary;
            this.hiredate = hiredate;
            this.gender = gender;
            this.security = security;
        }

        public void SetName(String name)
        {
            this.Name = name;
        }
        public string getName()
        {
            return this.Name;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
        public int GetId()
        {
            return this.id;
        }
        public void SetSalary(int sal)
        {
            this.salary = sal;
        }
        public int GetSal()
        {
            return this.salary;
        }
        public void SetGender(Gender g)
        {
            this.gender = g;
        }
        public Gender getgender()
        {
            return this.gender;
        }
        public Hiredate getdate()
        {
            return this.hiredate;
        }
        public void setdate(Hiredate hiredate)
        {
            this.hiredate = hiredate;
        }
        public void setsecurity(Security s)
        {
            this.security = s;
        }
        public Security GetSecurity()
        {
            return this.security;
        }

        public override string ToString()
        {
            return $"(Name is {Name} : Salary is {salary}$ : ID is {id} : HireDate is {hiredate.ToString()} : Gender is {gender} : security Level is {security})";
        }
    }
}


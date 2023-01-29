internal partial class Program
{
    public struct Search
    {
        public long[] NationalIDs = new long[3];
        public Employee[] emp = new Employee[3];
        public Search()
        {

        }
        public void National(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                NationalIDs[i] = employees[i].Id;
            }
        }
        public void FillEmp(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                emp[i] = employees[i];
            }
        }
      

    
     
      

        public Employee this[string name]
        {
            get
            {
                for (int i = 0; i < emp.Length; i++)
                    if (emp[i].Name == name)
                        return emp[i];

                return default;
            }
        }
        public Employee this[int Id]
        {
            get
            {
                for (int i = 0; i < emp.Length; i++)
                    if (NationalIDs[i] == Id)
                        return emp[i];

                return default;
            }
        }
        public Employee this[Hiredate date]
        {
            get
            {
                for (int i = 0; i < emp.Length; i++)
                    if (emp[i].Hiredate.Equals(date))
                        return emp[i];

                return default;
            }
        }

    }
}
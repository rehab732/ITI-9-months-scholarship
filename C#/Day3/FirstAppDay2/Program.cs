namespace FirstAppDay2
{
    class program
    {
        static void Main(String[] args)
        {

             Employee[] employee = new Employee[2];
            
            for (int i = 0;i < 2; i++) {
                bool flag=true;
                bool flag2=true;
                Console.WriteLine($"Enter Data of Employee number {i+1}");
                Console.WriteLine("Enter Name :");
                String name = Console.ReadLine();
                Console.WriteLine("Enter ID :");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Salary :");
                int sal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Gender");

                String res = String.Empty;
                while (flag)
                {
                    res = Console.ReadLine();
                    if (res == "Male" || res == "male"||res=="m"||res=="M")
                    {
                        res = "M";
                        flag= false;
                    }
                    else if (res == "female" || res == "Female"||res=="f"||res=="F")
                    {
                        res = "F";
                        flag= false;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid data");
                    }
               
                }
                Gender gg = (Gender)Enum.Parse(typeof(Gender), res);


                Console.WriteLine("Enter Security Level");
                string secc = String.Empty;
                while(flag2)
                {
                    secc = Console.ReadLine();
                    if (secc == "Developer")
                    {
                        secc = "Developer";
                        flag2 = false;
                    }
                    else if (secc == "DBA")
                    {
                        secc = "DBA";
                        flag2 = false;
                    }
                    else if (secc == "guset")
                    {
                        secc = "guset";
                        flag2 = false;
                    }
                    else if (secc == "secretary")
                    {
                        secc = "secretary";
                        flag2 = false;
                    }
                    else if (secc == "fullpermission")
                    {
                        secc = "fullpermission";
                        flag2 = false;
                    }
                    else
                    {
                        Console.WriteLine("Enter valid data");
                    }

                }

                Security sec = (Security)Enum.Parse(typeof(Security), secc);
                Console.WriteLine("Enter day of hiredate");
                int day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Month of hiredate");
                int month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Year of hiredate");
                int year = int.Parse(Console.ReadLine());
                Hiredate hiredate = new Hiredate(day, month, year);
                employee[i] = new Employee(name, id, sal, hiredate, gg, sec);
            }
             for(int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Data For Emplyee number {i+1}");
                Console.WriteLine( employee[i].ToString());
            }





        }


    }
}


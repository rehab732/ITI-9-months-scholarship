using static System.Runtime.InteropServices.JavaScript.JSType;

internal partial class Program
{

    private static void Main(string[] args)
    {
        System.Console.WriteLine("Hello In Our Program");
        System.Console.WriteLine("===========================");

        Employee[] employee= new Employee[3];
        for (int i=0;i<3;i++)
        {
            bool flag1=true;
            bool flag2=true;
            Console.WriteLine($"Enter Data for Employee number : {i + 1}");
            System.Console.WriteLine("Enter Name :");
            employee[i].Name=Console.ReadLine();
            System.Console.WriteLine("Enter Id :");
            employee[i].Id = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Salary :");
            employee[i].Salary = decimal.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Gender :");

            string gen = string.Empty;
            while (flag1)
            {
                gen= Console.ReadLine();
                if(gen=="m"||gen=="M"||gen=="Male"||gen=="male")
                {
                    gen = "M";
                    flag1 = false;

                }else if(gen=="f"||gen=="F"||gen=="female"||gen=="Female")
                {
                    gen = "F";
                    flag1 = false;

                }else
                {
                    Console.WriteLine("Enter valid Gender M or F");

                }
            }
            employee[i].Gender = (Gender)Enum.Parse(typeof(Gender), gen);

            System.Console.WriteLine("Enter Security Level :");
            string sec = string.Empty;
            while (flag2)
            {
                sec= Console.ReadLine();
                if(sec== "Developer" || sec == "DBA" || sec == "guset" || sec == "secretary" || sec == "fullpermission")
                {
                    flag2 = false;
                }
                else
                {
                    Console.WriteLine("Enter valid Security Level");
                }

            }
            employee[i].Security = (Security)Enum.Parse(typeof(Security), sec);
            System.Console.WriteLine("Enter Hiredate  :");
            Hiredate hiredate=new Hiredate();
            System.Console.WriteLine("Enter Day  :");
            hiredate.Day=int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Month  :");
            hiredate.Month = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Enter Year  :");
            hiredate.Year = int.Parse(Console.ReadLine());
            employee[i].Hiredate= hiredate;
            Console.Clear();


        }
        Console.Clear();
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Data For Emplyee number {i + 1}");
            Console.WriteLine(employee[i].ToString());
        }
        Console.WriteLine("=====================");
        Console.WriteLine("Searching Output");

        Search search = new Search();
        search.National(employee);
        search.FillEmp(employee);
        
        
        Console.WriteLine(search["Rehab"]);
        Console.WriteLine(search[44]);







    }
}
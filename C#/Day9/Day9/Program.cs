using Day9;

internal class Program
{
    private static void Main(string[] args)
    {
        Department dep1 = new() { DeptID = 1,DeptName="Data Analysis" };
        Club club1 = new() { ClubID = 1, ClubName = "ITI" };
        BoardMember boardMember1 = new() { EmployeeID = 1, BirthDate = new DateTime(1955, 1, 1), VacationStock = 30 };
        SalesPerson salesPerson1 = new() { EmployeeID = 2, BirthDate = new DateTime(1955, 1, 1), AchievedTarget = 0, VacationStock = 30 };
        Employee emp1 = new() { EmployeeID = 3, BirthDate = new DateTime(1955, 1, 1), VacationStock = 30 };

        dep1.AddStaff(boardMember1);
        club1.AddMember(boardMember1);

        dep1.AddStaff(salesPerson1);
        club1.AddMember(salesPerson1);

        dep1.AddStaff(emp1);
        club1.AddMember(emp1);
        Console.WriteLine("==============");


        boardMember1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(80));
        salesPerson1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(80));
        emp1.RequestVacation(DateTime.Now, DateTime.Now.AddDays(80));

        Console.WriteLine("==============");


        boardMember1.EndOfYearOperation();
        salesPerson1.EndOfYearOperation();
        emp1.EndOfYearOperation();
        Console.WriteLine("==============");


        boardMember1.Resign();
        salesPerson1.CheckTarget(50);
    }
}
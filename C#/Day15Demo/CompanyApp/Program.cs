using CompanyApp.Context;
using CompanyApp.Entites;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        using CompanyContext context=new CompanyContext();
        context.Database.Migrate();//nested of update database

        context.Add(new Employee() { FName = "Rehab", LName = "Zaki", MName = "Af", Salary = 100000 });

        Console.WriteLine(context.SaveChanges());

    }
}
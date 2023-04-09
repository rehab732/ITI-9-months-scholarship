namespace Day1.Models;

public class Mobile
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Model { get; set; }= string.Empty;
    public double Price { get; set; }   

    public Mobile(int id, string name, string model, double price)
    {
        Id = id;
        Name = name;
        Model = model;
        Price = price;
    }
    public static List<Mobile> _mobiles = new List<Mobile>()
    {
        new (1,"bjkj","nlkn",4544),
        new (2,"ankax","smal",4544),
        new (3,"ssak","cskln",4544),
        new (4,"salsx","sano",4544),
        new (5,"sla","aUsigi",4544),

    };
    //public static List<Mobile> GetMobiles() => _mobiles;
}

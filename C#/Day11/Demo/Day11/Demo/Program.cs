
using Demo;

internal class Program
{
    private static void Main(string[] args)
    {
        #region overriding gethash
        /*
        Point p1 = new() { X = 10, Y = 10 };
        Point p2 = new() { X = 5, Y = 15 };
        Point p3 = new() { X = 2, Y = 50 };
        Point p4 = p1;//p1&p2 same identity
        Console.WriteLine($"p1 :{p1.GetHashCode()}");
        Console.WriteLine($"p2 :{p2.GetHashCode()}");
        Console.WriteLine($"p3 :{p3.GetHashCode()}");
        Console.WriteLine($"p4 :{p4.GetHashCode()}");
        //dictionary<key,value>----> key must be unique
        Dictionary<Point, string> mydic = new();
        mydic.Add(p1, "left");
        mydic.Add(p2, "right");
        if (mydic.TryAdd(p3, "new corner"))
            Console.WriteLine("P3 Added");
        else
            Console.WriteLine("Already p3");
        // mydic.Add(p4, "bottom");//error

        /*
               if(mydic.TryGetValue(p3,out string str))
                    Console.WriteLine(str);
               else Console.WriteLine("p3 Not found");

                if (mydic.TryGetValue(p4, out string  mm))
                    Console.WriteLine(mm);
                else Console.WriteLine("p4 Not found");*/
        
        #endregion
        
    }
}
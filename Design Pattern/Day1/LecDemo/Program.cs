using LecDemo.Stratgy_Pattern;

internal class Program
{
    private static void Main(string[] args)
    {
        MallerdDuck mduck = new();
        mduck.Swim();
        mduck.Fly();//delefate call to know how to fly///call normal fly
        mduck.Quack();
        mduck.Display();
        Console.WriteLine("========================");
        RubberDuck rduck= new RubberDuck();
        rduck.Swim();
        rduck.Fly();
        rduck.Quack();
        rduck.Display();
        ///////////////
        // Another Mode
        Console.WriteLine("========================");
        //Apply o princople
        mduck.ifly = new NoFly();//change behavior in the runtime
        mduck.Fly();//delefate call to know how to fly///call Not fly



    }
}
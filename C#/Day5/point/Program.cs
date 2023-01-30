internal class Program
{
    public class Point3D
    {
        public int x;
        public int y;
        public int z;
        //parameter constructor
        public Point3D(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;

        }
        //chaining constructors 
        public Point3D() : this(0, 0, 0) { }
        public Point3D(int x) : this(x, x, x) { }

        //All properties

        public int X
        {
            get { return x; }
            set { x = value; }

        }
        public int Y
        {
            get { return y; }
            set { y = value; }

        }

        public int Z
        {
            get { return z; }
            set { z = value; }

        }
        //operator overloading for casting string 
        public static explicit operator string(Point3D p)
        {
            return p.ToString();
        }
        //operator overloading for == & !=
        public static bool operator == (Point3D p1, Point3D p2)
        {
            return p1.z == p2.z && p1.x == p2.x && p1.y == p2.y;


        }
        public static bool operator != (Point3D p1, Point3D p2)
        {
            return p1.z != p2.z || p1.x != p2.x || p1.y != p2.y;
        }

        //overriding to string
        public override string ToString()
        {
            return $"-->Point Coordinate : ({x},{y},{z})";
        }

        


    }
    private static void Main(string[] args)
    {
        Point3D P = new Point3D(10, 10, 10);
        Console.WriteLine(P.ToString());
        Point3D P2 = new Point3D(15, 12, 13);
        string ps2 = (string)P2;//casting for string
        Console.WriteLine(ps2);


        Point3D[] points=new Point3D[2];
        for(int i=0; i<2; i++)
        {
            Console.WriteLine($"Enter Coordinate for point number {i+1}");
            int m,n,v;
            do
            {
                Console.WriteLine($"Enter x :");


            } while (!int.TryParse(Console.ReadLine(), out m));
            do
            {
                Console.WriteLine($"Enter y :");


            } while (!int.TryParse(Console.ReadLine(), out n));
            do
            {
                Console.WriteLine($"Enter z :");


            } while (!int.TryParse(Console.ReadLine(), out v));
            points[i]=new Point3D(m,n,v);
        }

        foreach(Point3D p in points)
        {
            Console.WriteLine(p.ToString());
        }
        Point3D PP = new Point3D(10, 10, 5);
        Point3D PC = new Point3D(10, 10, 10);
        if (PP == PC)
        {
            Console.WriteLine("Two points are equal");
        }
        else
        {
            Console.WriteLine("Two points are Not equal");


        }




    }
}
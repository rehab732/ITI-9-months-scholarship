using System.Security.Cryptography.X509Certificates;

internal class Program
{
    public class Duration
    {
        int hours;
        int min;
        int sec;
         //All proerties
         public int Hours
        {
            get { return hours; }
            set { hours = value; }

        }
        public int Min
        {
            get { return min; }
            set { min = value; }

        }
        public int Sec
        {
            get { return sec; }
            set { sec = value; }

        }

        //constructor
        public Duration(int hours=0, int min=0, int sec=0)
        {
            this.hours = hours;
            this.min = min;
            this.sec = sec;
        }

        public Duration(int time)
        {
            hours = time / 3600;
            min = (time - hours) / 60;
            sec = time % 60;
        }
        //override all function 
        //1) tostring
        public override string ToString()
        {
            return $" Hours:{hours},Minutes:{min},Seconds:{sec}";
        }
        //2)Equals
        public override bool Equals(Object? obj)
        {
            if (obj == null)
                return false;

            Duration d = (Duration)obj;
            return this.hours == d.hours && this.min == d.min && this.sec == d.sec;

        }

        //operator overloading
        //1)D3=D1+D2
        public static Duration operator+ (Duration a, Duration b)
        {
            return new()
            {
                hours = (a?.hours ?? 0) + (b?.hours ?? 0),
                min = (a?.min ?? 0) + (b?.min ?? 0),
                sec = (a?.sec ?? 0) + (b?.sec ?? 0),
            };
        }
        //2)D3=D1 + 7800
        public static Duration operator +(Duration a, int b)
        {
            int hour = b / 3600;
            return new()
            {
                hours = (a?.hours ?? 0) + hour,
                min = (a?.min ?? 0) + (b - hour) / 60,
                sec = (a?.sec ?? 0) + b % 60,
            };
        }
        //3)D3=7800+D2
        public static Duration operator+(int n,Duration s)
        {
            int hour = n / 3600;
            return new()
            {
                hours = (s?.hours ?? 0) + hour,
                min = (s?.min ?? 0) + (n - hour) / 60,
                sec = (s?.sec ?? 0) + n % 60,
            };
        }
        //4)D3=D1++ (Increase One Minute)

        public static Duration operator ++(Duration d1)
        {
            d1.min = d1.min + 1;
            return d1;
        }
        //5)D3 =--D2; (Decrease One Minute)

        public static Duration operator --(Duration d1)
        {
            d1.min = d1.min - 1;
            return d1;
        }
        //6)D1= -D2;
        public static Duration operator -(Duration a, Duration b)
        {
            return new()
            {
                hours = (a?.hours ?? 0) - (b?.hours ?? 0),
                min = (a?.min ?? 0) - (b?.min ?? 0),
                sec = (a?.sec ?? 0) - (b?.sec ?? 0),
            };
        }
        //7)If ( D1>D2);
        public static bool operator >(Duration d1, Duration d2)
        {
            if (d1 == null)
                return false;
            return d1.hours > d2.hours && d1.min > d2.min && d1.sec > d2.sec;
        }
        public static bool operator <(Duration d1, Duration d2)
        {
            if (d1 == null)
                return false;
            return d1.hours < d2.hours && d1.min < d2.min && d1.sec < d2.sec;
        }
        //8)If ( D1<=D2);

        public static bool operator <=(Duration d1, Duration d2)
        {
            if (d1 == null)
                return false;
            return d1.hours <= d2.hours && d1.min <= d2.min && d1.sec <= d2.sec;
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            if (d1 == null)
                return false;
            return d1.hours >= d2.hours && d1.min >= d2.min && d1.sec >= d2.sec;
        }

        //9)If (D1);

        public static bool operator true(Duration d1)
        {
            if (d1 is null)
                return false;
            else
                return true;
        }

        public static bool operator false(Duration d1)
        {
            if (d1 is null)
                return false;
            else
                return true;
        }

        //10)DateTime Obj = (DateTime) D1
        public static explicit operator DateTime(Duration d1)
        {
            return new DateTime(1976, 10, 24 ,d1.hours, d1.min, d1.sec);
        }


    }
    private static void Main(string[] args)
    {
        Duration duration= new Duration(1,20,30);
        Console.WriteLine(duration.ToString());

        Duration D1 = new Duration(1, 20, 30);
        Duration D2 = new Duration(1, 20, 30);
        Duration D3 = D1+ D2;
        Console.WriteLine(D3.ToString());

        Duration D4 = D1 + 3600;
        Console.WriteLine(D4.ToString());

        D3 = D4++;
        Console.WriteLine(D3.ToString());

        if(D1>D2)
        {
            Console.WriteLine("D1>D2");
        }
        else
        {
            Console.WriteLine("Not");
        }


        if (D1 <= D2)
        {
            Console.WriteLine("D1<=D2");
        }
        else
        {
            Console.WriteLine("Not");
        }
        if(D4)
        {
            Console.WriteLine("Not null");

        }else
            Console.WriteLine(" null");

        DateTime t = (DateTime)D1;
        Console.WriteLine(t.ToString());






    }
}
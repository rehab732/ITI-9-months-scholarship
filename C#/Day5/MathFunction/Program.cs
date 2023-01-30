internal class Program
{
    public static class MathFun
    {
        public static int Add(int a, int b) { return a + b; }
        public static int Sub(int a, int b) { return a - b; }
        public static int Mul(int a, int b) { return a * b; }
        public static int Div(int a, int b) { return a / b; }

        private static void Main(string[] args)
        {
            Console.WriteLine($" Add Function :{MathFun.Add(2, 3)}");
            Console.WriteLine($" Sub Function :{MathFun.Sub(15, 3)}");
            Console.WriteLine($" Mul Function :{MathFun.Mul(2, 3)}");
            Console.WriteLine($" Div Function :{MathFun.Div(10, 2)}");

        }
    }
}
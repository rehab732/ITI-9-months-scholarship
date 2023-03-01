using System.Diagnostics;

namespace ThirdApp{
 class Program
{
    private static void Main(string[] args)
    {
            Stopwatch sw = Stopwatch.StartNew();
            
            int counter = 0;
            for(int i=1;i<=99999999;i++)
            {
                int temp = i;
                while(temp!=0)
                {
                    int mod = temp % 10;
                    if(mod==1)
                    {
                        counter++;
                    }
                    temp/= 10;
                }
            }
            Console.WriteLine(counter);
   

            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
    }
}
}
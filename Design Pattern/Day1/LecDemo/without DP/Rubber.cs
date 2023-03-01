using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.without_DP
{
    //rubber duck wala btfly wla btquack
    public class Rubber : Duck
    {
        public override void Display()
        {
            Console.WriteLine("Rubber Duck");

        }
        public new void  Fly() => Console.WriteLine("Rubber Duck Can't Fly");
        public new void Quack()
        {
            Console.WriteLine("Sqeeek not quack");
            Console.Beep(32767, 1500);
        }

    }
}

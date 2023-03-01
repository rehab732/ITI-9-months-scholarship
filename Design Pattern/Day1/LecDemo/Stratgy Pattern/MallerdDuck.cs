using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.Stratgy_Pattern
{
    public class MallerdDuck : Duck
    {
        public MallerdDuck() : base(new NormalFlying(), new NormalQuack())//initial behavior and can change it in the run time
        {
        }

        public override void Display()
        {
            Console.WriteLine("Mallard Duck");
        }
    }
}

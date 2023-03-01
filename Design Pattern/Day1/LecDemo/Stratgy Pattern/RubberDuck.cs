using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.Stratgy_Pattern
{
    public class RubberDuck : Duck
    {
        public RubberDuck() : base(new NoFly(), new SeekQuack())
        {
        }

        public override void Display()
        {
            Console.WriteLine("Rubber Duck");
        }
    }
}

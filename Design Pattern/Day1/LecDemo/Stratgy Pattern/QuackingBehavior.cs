using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.Stratgy_Pattern
{
    public abstract class QuackingBehavior
    {
        public abstract void performQuack();
    }
    public class NormalQuack : QuackingBehavior
    {
        public override void performQuack()
        {
            Console.WriteLine("Normal Quack");
            Console.Beep();
        }
    }
    public class SeekQuack: QuackingBehavior
    {
        public override void performQuack()
        {
            Console.WriteLine("Seek Quack");
            Console.Beep(32767,1500);
        }
    }

}

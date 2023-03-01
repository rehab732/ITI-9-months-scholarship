using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecDemo.Stratgy_Pattern
{
    public interface IFlyBehavior
    {
         void PerformFly();
    }

    public class NormalFlying:IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Normal Fly");
        }
    }

    public class NoFly: IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Can't Fly");
        }

    }
    public class FastFly: IFlyBehavior
    {
        public void PerformFly()
        {
            Console.WriteLine("Fast Fly");
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public interface Player
    {
        void PassBall()
        {
            Console.WriteLine("Welcom in Player interface : Pass Ball Function");
        }
    }
}

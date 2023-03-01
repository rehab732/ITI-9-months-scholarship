using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Defiender:PlayerRole
    {
       public void Defend()
        {
            Console.WriteLine("Defender Function in Defend Class");
        }
    }
}

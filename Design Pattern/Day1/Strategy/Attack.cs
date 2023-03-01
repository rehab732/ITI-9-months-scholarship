using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Attack : TeamStrategy
    {
        public override void Play()
        {
            Console.WriteLine("Welcom in Attack");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBall
{
    public class Player : Observer
    {
        Position ballpos;
        Position Ballpos
        {
            get; set;
        }
        public override void Update()
        {
            Console.WriteLine("Player Updated");

        }
    }
}

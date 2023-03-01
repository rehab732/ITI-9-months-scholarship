using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBall
{
    public class Football:Ball
    {
        Position mypos;
        public Position GetBallPOsition()
        {
            return mypos;
        }
        public void SetBallPOsition(Position pos)
        {
            mypos = pos;
            Notify();
        }
    }
}

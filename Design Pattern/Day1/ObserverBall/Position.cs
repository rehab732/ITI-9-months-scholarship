using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBall
{
    public class Position
    {
        int x;
        int y;
        int z;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public int Z
        {
            get { return z; }
            set { z = value; }
        } 
        public Position(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
          
        }
    }
}

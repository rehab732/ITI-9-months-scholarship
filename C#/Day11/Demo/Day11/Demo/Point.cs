using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public  class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return$"({X},{Y})";
        }
        public override int GetHashCode()
        {
            return X*Y;
        }

        public override bool Equals(object? obj)
        {
            if((obj!=null)&&(obj is Point r)&&(this.GetType()==r.GetType())) 
            {
                if(object.ReferenceEquals(this, r)) return true;
                return X==r.X && Y==r.Y;

            }return false;
        }
    }
}

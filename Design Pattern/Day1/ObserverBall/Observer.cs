using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBall
{
    public abstract class Observer
    {
        public virtual void Update()
        {
            Console.WriteLine("Observer Updated ...");
        }
    }


 

}

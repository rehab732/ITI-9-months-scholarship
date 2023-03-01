using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.withoutEvents
{
    public class observerA : IObserver
    {
        public void Update(IObservable observable)
        {
            if ((observable as Observable).State < 3)
            {
                Console.WriteLine("observerA reacted to the event ");
            }
        }
    }
    public class observerB : IObserver
    {
        public void Update(IObservable observable)
        {
            if ((observable as Observable).State < 3)
            {
                Console.WriteLine("observerB reacted to the event ");
            }
        }
    }
}

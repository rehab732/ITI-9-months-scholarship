using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.withoutEvents
{
    public class Observable : IObservable
    {
        //this class implemented IObservable interface 
        //keep track on the subscribers and votify them if state changed 
        private List<IObserver> observers = new List<IObserver>();
        private int state;
        public int State
        {
            get { return state; }
            set
            {
                state = value;
                Notify();
            }
        }

        public void Attach(IObserver observer)
        {
            Console.WriteLine("Observable Attached Observer ");
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
            Console.WriteLine("Observable Detached Observer");
        }

        public void Notify()
        {
            Console.WriteLine("Observable notifing all Observaers.");
            foreach (var o in observers)
            {
                o.Update(this);
            }
        }
    }
}

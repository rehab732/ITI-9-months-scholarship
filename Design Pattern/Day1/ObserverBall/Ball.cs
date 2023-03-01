using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverBall
{
    //publisher
    public abstract class  Ball
    {
     List<Observer> observers=new List<Observer>();
        public void Attach(Observer observer)
        {
            observers.Add(observer);
            Console.WriteLine("Observer Added");

        }
        public void Detach(Observer observer)
        {
            observers.Remove(observer);
            Console.WriteLine("Observer Removed");

        }
        public void Notify()
        {
            foreach(var o in observers)
            {
                o.Update();
            }
        }


    }
}

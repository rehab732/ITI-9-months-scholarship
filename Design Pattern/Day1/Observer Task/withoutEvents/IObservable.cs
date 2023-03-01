using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.withoutEvents
{
    public interface IObservable
    {
        //method to manage subscribers
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify();

    }


}

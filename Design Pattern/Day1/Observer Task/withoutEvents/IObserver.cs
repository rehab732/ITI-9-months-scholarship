using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.withoutEvents
{
    public interface IObserver
    {
        void Update(IObservable observable);
    }
}

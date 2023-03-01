using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.WithEvents
{
    public class ObserversAEvent
    {
        public void ReactToEvent(int state)
        {
            if(state<3)
            {
                Console.WriteLine("ObserversA Reacted to the event");
            }    
        }
    }
    public class ObserversBEvent
    {
        public void ReactToEvent(int state)
        {
            if (state==0 || state>=2)
            {
                Console.WriteLine("ObserversB Reacted to the event");
            }
        }
    }
}

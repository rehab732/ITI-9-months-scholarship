using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Task.WithEvents
{
    public class ObservableEvent
    {
        public delegate void StateChangedEventHandler(int state);
        public event StateChangedEventHandler statechanged;
        private int state;
        public int State
        {
            get { return state; }
            set {
                state = value;
                OnStateChanged();

            }
        }
        protected virtual void OnStateChanged()
        {
            statechanged?.Invoke(state);
        }
    }
}

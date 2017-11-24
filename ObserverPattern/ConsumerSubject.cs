using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class ConsumerSubject
    {
        private List<IRawDataObserver> _observers = new List<IRawDataObserver>();

        public void Attach(IRawDataObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IRawDataObserver observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

    }
}

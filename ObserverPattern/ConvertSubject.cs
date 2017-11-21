using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class ConvertSubject
    {
        private List<IMeasurementObserver> _observers = new List<IMeasurementObserver>();

        public void Attach(IMeasurementObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IMeasurementObserver observer)
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

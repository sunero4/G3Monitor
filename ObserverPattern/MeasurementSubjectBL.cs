using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public abstract class MeasurementSubjectBL
    {
        private List<IPresentationObserver> _observers = new List<IPresentationObserver>();
        public void Attach(IPresentationObserver observer)
        {
            _observers.Add(observer);
        }

        public void Detach(IPresentationObserver observer)
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

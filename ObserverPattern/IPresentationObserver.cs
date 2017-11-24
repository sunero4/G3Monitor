using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface IPresentationObserver
    {
        void Update();
        void AttachToSubject(MeasurementSubjectBL subject);
        void DetachFromSubject(MeasurementSubjectBL subject);

    }
}

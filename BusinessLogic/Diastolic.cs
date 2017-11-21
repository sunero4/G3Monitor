using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class Diastolic : MeasurementSubjectBL, IMeasurementObserver
    {
        public List<double> BloodPressureValues { get; set; }
        private readonly VoltageToPressureConversion _subject;

        public Diastolic(VoltageToPressureConversion subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void Update()
        {
            BloodPressureValues = _subject.ConvertedBPState;
        }
    }
}

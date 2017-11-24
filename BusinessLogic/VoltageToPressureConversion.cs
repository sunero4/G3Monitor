using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class VoltageToPressureConversion : ConvertSubject, IRawDataObserver
    {
        private BPConsumer _subject;
        private List<double> _bpValues;
        public List<double> ConvertedBPState { get; set; }

        public VoltageToPressureConversion(BPConsumer subject)
        {
            _subject = subject;
            _subject.Attach(this);
        }

        public void HandleData()
        {
            ConvertedBPState = ConvertToPressure(_bpValues);
        }

        public List<double> ConvertToPressure(List<double> bp)
        {
            //Do something
            return bp;
        }

        public void Update()
        {
            _bpValues = _subject.BPState;
        }
    }
}

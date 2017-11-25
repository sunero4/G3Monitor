using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class VoltageToPressureConversion
    {
        private BPConsumer _subject;
        private List<double> _bpValues;
        public List<double> ConvertedBPState { get; set; }



        public void HandleData()
        {
            ConvertedBPState = ConvertToPressure(_bpValues);
        }

        public List<double> ConvertToPressure(List<double> bp)
        {
            //Do something
            return bp;
        }
    }
}

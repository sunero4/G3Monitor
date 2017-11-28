using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic
{
    public class Saving
    {
        private BPConsumer _subject;
        public List<double> BloodPressureValues { get; set; }

        public Saving(BPConsumer subject)
        {
            _subject = subject;
 
            //Strategy pattern til gem her
        }

        public void Update()
        {
            BloodPressureValues = _subject.BPState;
        }

    }
}

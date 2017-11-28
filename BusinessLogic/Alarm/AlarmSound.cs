using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using ObserverPattern;

namespace BusinessLogic.Alarm // Ikke færdig
{
    class AlarmSound: IAlarm, IPresentationObserver
    {
        // over eller under min og max, går alarmen i gang. 
        private int _maxValueDia;
        private int _maxValueSys;
        private int _minValueDia;
        private int _minValueSys;
        //private int _newValue;
        private PresentationDataContainer _PresentationDataContainer;
        SoundPlayer myAlarmSound = new SoundPlayer("//Mac/Home/Documents/1.Sundhedsteknologi/DSB/Del 1 Digital Signalbehandling/OpgaveløsningerL1(1)/sound.wav"); // STIEN skal være til computeren, der kører programmet!

        public AlarmSound(PresentationDataContainer presentationDataContainer)
        {
            _PresentationDataContainer = presentationDataContainer;
        }
        public void StartAlarm(int sys, int dia)
        {
            if (_maxValueDia < dia || _minValueDia > dia || _maxValueSys < sys || _minValueSys > sys)
            {
                myAlarmSound.PlayLooping(); 
            }
            else if (_maxValueDia > dia & _minValueDia < dia & _maxValueSys > sys & _minValueSys < sys)
            {
                myAlarmSound.Stop();
            }
        }

        public void Update()
        {
            StartAlarm(_PresentationDataContainer.SystolicPressure, _PresentationDataContainer.DiastolicPressure);
        }

        public void AttachToSubject(MeasurementSubjectBL subject)
        {
            throw new NotImplementedException();
        }

        public void DetachFromSubject(MeasurementSubjectBL subject)
        {
            throw new NotImplementedException();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using DTO;
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

        private Monitoreringsindstillinger _monitoreringsindstillinger;
        SoundPlayer myAlarmSound = new SoundPlayer("//Mac/Home/Documents/1.Sundhedsteknologi/DSB/Del 1 Digital Signalbehandling/OpgaveløsningerL1(1)/sound.wav"); // STIEN skal være til computeren, der kører programmet!

        public AlarmSound(PresentationDataContainer presentationDataContainer, Monitoreringsindstillinger monitoreringsindstillinger)
        {
            _PresentationDataContainer = presentationDataContainer;
            _monitoreringsindstillinger = monitoreringsindstillinger;
        }
        public void StartAlarm(int sys, int dia)
        {
            if (_monitoreringsindstillinger.MaximumDiastolic < dia || _monitoreringsindstillinger.MinimumDiastolic > dia || _monitoreringsindstillinger.MaximumSystolic < sys || _monitoreringsindstillinger.MinimumSystolic > sys)
            {
                myAlarmSound.PlayLooping(); 
            }
            else if (_monitoreringsindstillinger.MaximumDiastolic > dia & _monitoreringsindstillinger.MinimumDiastolic < dia & _monitoreringsindstillinger.MaximumSystolic > sys & _monitoreringsindstillinger.MinimumSystolic < sys)
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
            subject.Attach(this);
        }

        public void DetachFromSubject(MeasurementSubjectBL subject)
        {
            subject.Detach(this);
        }
    }
}
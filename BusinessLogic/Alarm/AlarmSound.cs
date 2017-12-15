using System.Media;
using DTO;
using ObserverPattern;

namespace BusinessLogic.Alarm
{
    public class AlarmSound : IAlarm, IPresentationObserver
    {
        // over eller under min og max, går alarmen i gang. 
        private int _maxValueDia;
        private int _maxValueSys;
        private int _minValueDia;
        private int _minValueSys;
        private bool _isPlaying;
        private PresentationDataContainer _PresentationDataContainer;

        private Monitoreringsindstillinger _monitoreringsindstillinger;
        SoundPlayer myAlarmSound = new SoundPlayer(@"C:\Users\Anders\Desktop\alarm.wav"); // STIEN skal være til computeren, der kører programmet!

        public AlarmSound(PresentationDataContainer presentationDataContainer, Monitoreringsindstillinger monitoreringsindstillinger)
        {
            _PresentationDataContainer = presentationDataContainer;
            _monitoreringsindstillinger = monitoreringsindstillinger;
            _isPlaying = false;
        }
        /// <summary>
        /// Evaluates whether or not to start the alarm based on the supplied bloodpressure values
        /// </summary>
        /// <param name="sys">Systolic pressure</param>
        /// <param name="dia">Diastolic pressure</param>
        public void StartAlarm(int sys, int dia)
        {
            if ((_monitoreringsindstillinger.MaximumDiastolic < dia || _monitoreringsindstillinger.MinimumDiastolic > dia || _monitoreringsindstillinger.MaximumSystolic < sys || _monitoreringsindstillinger.MinimumSystolic > sys) && _isPlaying == false)
            {
                myAlarmSound.PlayLooping();
                _isPlaying = true;
            }
            else if (_monitoreringsindstillinger.MaximumDiastolic > dia & _monitoreringsindstillinger.MinimumDiastolic < dia & _monitoreringsindstillinger.MaximumSystolic > sys & _monitoreringsindstillinger.MinimumSystolic < sys)
            {
                StopAlarm();
            }
        }

        /// <summary>
        /// Update method for observer pattern
        /// </summary>
        public void Update()
        {
            StartAlarm(_PresentationDataContainer.SystolicPressure, _PresentationDataContainer.DiastolicPressure);
        }

        /// <summary>
        /// Stops the alarm playing
        /// </summary>
        public void StopAlarm()
        {
            myAlarmSound.Stop();
            _isPlaying = false;
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

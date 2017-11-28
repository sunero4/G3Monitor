using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace BusinessLogic.Alarm // Ikke færdig
{
    class AlarmSound: IAlarm
    {
        // over eller under min og max, går alarmen i gang. 
        private int _maxValueDia;
        private int _maxValueSys;
        private int _minValueDia;
        private int _minValueSys;
        private int _newValue;
        SoundPlayer myAlarmSound = new SoundPlayer("//Mac/Home/Documents/1.Sundhedsteknologi/DSB/Del 1 Digital Signalbehandling/OpgaveløsningerL1(1)/sound.wav"); // STIEN skal være til computeren, der kører programmet!
        public void StartAlarm()
        {
            if (_maxValueDia < _newValue || _minValueDia > _newValue || _maxValueSys < _newValue || _minValueSys > _newValue)
            {
                myAlarmSound.PlayLooping(); 
            }
            else if (_maxValueDia > _newValue || _minValueDia < _newValue || _maxValueSys > _newValue || _minValueSys < _newValue)
            {
                myAlarmSound.Stop();
            }
        }
    }
}
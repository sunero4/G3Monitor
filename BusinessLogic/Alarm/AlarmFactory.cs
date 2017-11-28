using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic.Alarm
{
    class AlarmFactory // Ikke færdig 
    {
        public static IAlarm CreateAlarm(bool alarm)
        {
            if (alarm)
            {
               IAlarm _alarm = new AlarmSound();
               return _alarm;
            }

        }
    }
}
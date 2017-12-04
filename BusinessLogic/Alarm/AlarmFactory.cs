using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ObserverPattern;

namespace BusinessLogic.Alarm
{
    public class AlarmFactory
    {
        public static IAlarm CreateAlarm(PresentationDataContainer presentationDataContainer, Monitoreringsindstillinger monitoreringsindstillinger)
        {
            IAlarm _alarm = new AlarmSound(presentationDataContainer, monitoreringsindstillinger);
            return _alarm;
        }

    }
}

using DTO;
using ObserverPattern;

namespace BusinessLogic.Alarm
{
    public class AlarmFactory
    {
        /// <summary>
        /// Creates a new alarm object
        /// </summary>
        /// <param name="presentationDataContainer">Container to supply to the alarm constructor</param>
        /// <param name="monitoreringsindstillinger">DTO to supply to the alarm constructor</param>
        /// <returns>Alarm object</returns>
        public static IAlarm CreateAlarm(PresentationDataContainer presentationDataContainer, Monitoreringsindstillinger monitoreringsindstillinger)
        {
            IAlarm _alarm = new AlarmSound(presentationDataContainer, monitoreringsindstillinger);
            return _alarm;
        }

    }
}

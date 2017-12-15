using ObserverPattern;

namespace BusinessLogic.Alarm
{
    public interface IAlarm : IPresentationObserver
    {
        void StartAlarm(int sys, int dia);
        void StopAlarm();
    }
}

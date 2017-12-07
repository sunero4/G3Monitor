using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern;

namespace BusinessLogic.Alarm
{
    public interface IAlarm : IPresentationObserver
    {
        void StartAlarm(int sys, int dia);
    }
}

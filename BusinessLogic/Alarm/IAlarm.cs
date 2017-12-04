using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Alarm
{
    public interface IAlarm
    {
        void StartAlarm(int sys, int dia);
    }
}

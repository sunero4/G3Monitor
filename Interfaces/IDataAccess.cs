using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using ST2Prj2LibNI_DAQ;

namespace Interfaces
{
    public interface IDataAccess
    {
        MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder);


        byte[] GetSalt(MedarbejderDTO medarbejder);
        double GetVoltage();

    }
}

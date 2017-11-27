using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IDataAccess
    {
        MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder);

        void SaveCalibration(KalibreringsDTO kalibrering);
        byte[] GetSalt(MedarbejderDTO medarbejder);
        void GetData();
        PatientDTO HentData(PatientDTO patient);

        PatientDTO GetPatientInfo(PatientDTO patient);
    }
}

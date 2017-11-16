using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IBusinessLogic
    {
        bool CheckLogin(MedarbejderDTO medarbejder);


        byte[] GetSalt(MedarbejderDTO medarbejder);


        byte[] HashAndSaltPassword(string password, byte[] salt);

        NulpunktsjusteringDTO PerformAdjustment();

        PatientDTO HentData(PatientDTO patient);

        List<MaalingDTO> RetrievedDivider(byte[] bpValues);

        List<double> ConvertArrayToDoubles(byte[] maaledata); 

    }
}

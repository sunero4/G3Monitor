using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class SCDataAcess: IDataAccess

    {
        private RetrivedLoginData retrivedLoginData;
        private RetrievedData retrievedData;
        private Salt _salt;
        private IDaqMeasurement _daqMeasurement;
        private SaveCalibrationXml _saveCalibrationXml;
        private PatientInfoRetrieval _patientInfoRetrieval;

        public SCDataAcess()
        {
            retrivedLoginData = new RetrivedLoginData();
            retrievedData = new RetrievedData();
            _salt = new Salt();
            _patientInfoRetrieval = new PatientInfoRetrieval();
         
        }

        public PatientDTO GetPatientInfo(PatientDTO patient)
        {
            return _patientInfoRetrieval.HentData(patient);
        }

        public MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder)
        {
            return retrivedLoginData.CheckLogin(medarbejder);
        }

        public PatientDTO HentData(PatientDTO patient)
        {
            return retrievedData.HentData(patient); 
        }

        public void SaveCalibration(KalibreringsDTO kalibrering)
        {
            _saveCalibrationXml.Save(kalibrering);
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            return _salt.GetSalt(medarbejder); 
        }

        public double GetVoltage()
        {
            var daq = new DAQ();
            _daqMeasurement = new DaqMeasurementNulpunkt(daq.GetDaq());
            return _daqMeasurement.GetVoltage();
        }
    }

}


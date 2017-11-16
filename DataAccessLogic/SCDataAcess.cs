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
        private RetrivedData retrivedData;
        private Salt _salt;
        private IDaqMeasurement _daqMeasurement;
        private SaveCalibrationXml _saveCalibrationXml;
        private PatientInfoRetrieval _patientInfoRetrieval;

        public SCDataAcess()
        {
            retrivedData = new RetrivedData();
            _salt = new Salt();
            _patientInfoRetrieval = new PatientInfoRetrieval();
         
        }

        public PatientDTO GetPatientInfo(PatientDTO patient)
        {
            return _patientInfoRetrieval.HentData(patient);
        }

        public MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder)
        {
            return retrivedData.CheckLogin(medarbejder);
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


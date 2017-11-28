using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;
using ObserverPattern;

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
        private DAQData _producer;
        private DAQ _daq;
        private ICalibrationDataRetrieval _calibrationRetrieval;

        public SCDataAcess(ConcurrentQueue<BPDataContainer> queue)
        {
            retrivedLoginData = new RetrivedLoginData();
            retrievedData = new RetrievedData();
            _salt = new Salt();
            _patientInfoRetrieval = new PatientInfoRetrieval();
            _daq = new DAQ();
            _producer = new DAQData(_daq, queue);
            _calibrationRetrieval = new CalibrationRetrievalXml();
        }

        public PatientDTO GetPatientInfo(PatientDTO patient)
        {
            return _patientInfoRetrieval.HentData(patient);
        }

        public KalibreringsDTO GetCalibration()
        {
            return _calibrationRetrieval.GetCalibrationData();
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

        public void StartProducer()
        {
            _producer.Start();
        }
    }

}


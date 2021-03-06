﻿using System.Collections.Concurrent;
using DataAccessLogic.Gem;
using DTO;
using Interfaces;
using ObserverPattern;

namespace DataAccessLogic
{
    public class SCDataAccess: IDataAccess

    {
        private RetrivedLoginData retrivedLoginData;
        private RetrievedData retrievedData;
        private Salt _salt;
        private IDaqMeasurement _daqMeasurement;
        private SaveCalibrationXml _saveCalibrationXml;
        private PatientInfoRetrieval _patientInfoRetrieval;
        private DAQData _daqData;
        private DAQ _daq;
        private BPProducer _producer;
        private ICalibrationDataRetrieval _calibrationRetrieval;
        private Saving _saving;
        private DatabaseSaving _databaseSaving;
        private DaqGetSingleValue _daqGetSingleValue;

        public SCDataAccess(ConcurrentQueue<BPDataContainer> queue)
        {
            retrivedLoginData = new RetrivedLoginData();
            retrievedData = new RetrievedData();
            _salt = new Salt();
            _patientInfoRetrieval = new PatientInfoRetrieval();
            _daq = new DAQ();
            _daqData = new DAQData(_daq, queue);
            _calibrationRetrieval = new CalibrationRetrievalXml();
            _producer = new BPProducer(queue, _daqData);
            _saving = new Saving();
            _databaseSaving = new DatabaseSaving();
            _daqGetSingleValue = new DaqGetSingleValue();
            _saveCalibrationXml = new SaveCalibrationXml();
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
            _producer.GetData();
        }

        public void StopProducer()
        {
            _producer.CanRun = false;
        }

        public void SaveInitial(PatientDTO patient)
        {
            _databaseSaving.InitialSave(patient);
        }

        public void SaveBloodPressureData(PatientDTO patient)
        {
            _saving.SaveData(patient);
        }

        public double GetSinglePressureValue()
        {
            return _daqGetSingleValue.GetSingleValue();
        }
    }

}


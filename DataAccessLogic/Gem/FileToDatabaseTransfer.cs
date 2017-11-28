﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class FileToDatabaseTransfer
    {
        private IRetrievedData<List<MaalingDTO>> _dataRetrieval; 
        private ISaving _saving;

        public FileToDatabaseTransfer()
        {
            _dataRetrieval = new MeasurementRetrievalXml();
            _saving = new DatabaseSaving();
        }

        public void TransferToDatabase(PatientDTO patient)
        {
            GetData(patient);
            UploadToDatabase(patient);
        }

        public MaalingDTO GetData(PatientDTO patient) // SS 
        {
            //return _dataRetrieval.HentData(patient);
            return new MaalingDTO();
        }

        private void UploadToDatabase(PatientDTO patient)
        {
            _saving.SaveBloodPressureData(patient);
        }
    }
}

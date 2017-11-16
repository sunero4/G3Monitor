using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class FileToDatabaseTransfer
    {
        private IRetrievedData<MaalingDTO> _dataRetrieval;
        private ISaving _saving;
        private PatientDTO _patient;

        public FileToDatabaseTransfer(PatientDTO patient)
        {
            _patient = patient;
            _dataRetrieval = new MeasurementRetrievalXml();
            _saving = new DatabaseSaving();
        }

        public void TransferToDatabase()
        {
            GetData();
            UploadToDatabase();
        }

        private void GetData()
        {
            _dataRetrieval.HentData(_patient);
        }

        private void UploadToDatabase()
        {
            _saving.SaveBloodPressureData(_patient);
        }
    }
}

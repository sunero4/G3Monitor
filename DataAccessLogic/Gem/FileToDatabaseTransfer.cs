using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic.Hent;
using DTO;

namespace DataAccessLogic
{
    public class FileToDatabaseTransfer
    {
        private IRetrievedData<OperationsDTO> _dataRetrieval; 
        private ISaving _saving;

        public FileToDatabaseTransfer()
        {
            _dataRetrieval = new DataRetrievalXml();
            _saving = new DatabaseSaving();
        }

        public void TransferToDatabase(PatientDTO patient)
        {
            var patientOut = new PatientDTO();
            patientOut.ListOperation = new List<OperationsDTO>()
            {
                GetData(patient)
            };
            UploadToDatabase(patientOut);
        }

        public OperationsDTO GetData(PatientDTO patient) // SS 
        {
            return _dataRetrieval.HentData(patient);
        }

        private void UploadToDatabase(PatientDTO patient)
        {
            _saving.SaveBloodPressureData(patient);
        }
    }
}

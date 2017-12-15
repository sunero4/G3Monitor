using System.Collections.Generic;
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

        /// <summary>
        /// Transfers file content to database
        /// </summary>
        /// <param name="patient">PatientDTO holding the corresponding CPR to save operation data to</param>
        public void TransferToDatabase(PatientDTO patient)
        {
            var patientOut = new PatientDTO();
            patientOut.ListOperation = new List<OperationsDTO>()
            {
                GetData(patient)
            };
            UploadToDatabase(patientOut);
        }

        /// <summary>
        /// Gets file content
        /// </summary>
        /// <param name="patient">PatientDTO holding the CPR to check for in the file</param>
        /// <returns>Retrieved data</returns>
        public OperationsDTO GetData(PatientDTO patient) 
        {
            return _dataRetrieval.HentData(patient);
        }

        /// <summary>
        /// Saves the retrieved file content in the database
        /// </summary>
        /// <param name="patient">PatientDTO holding the retrieved data</param>
        private void UploadToDatabase(PatientDTO patient)
        {
            _saving.SaveBloodPressureData(patient);
        }
    }
}

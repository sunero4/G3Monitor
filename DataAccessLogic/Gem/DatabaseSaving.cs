using System.Data.SqlClient;
using DataAccessLogic.Gem;
using DTO;

namespace DataAccessLogic
{
    public class DatabaseSaving : ISaving
    {
        private ICommandBuilder<PatientDTO> _patientCommandBuilder;
        private ICommandBuilder<PatientDTO> _operationCommandBuilder;
        private ICommandBuilder<MaalingDTO> _measurementCommandBuilder;
        private IQueryBuilder<PatientDTO> _patientQueryBuilder;
        private IQueryBuilder<OperationsDTO> _operationQueryBuilder;
        private IQueryBuilder<MaalingDTO> _measurementQueryBuilder;
        private PatientInfoRetrieval _patientInfoRetrieval;
        private int _operationID;

        public DatabaseSaving()
        {
            _patientQueryBuilder = new PatientSaveQueryBuilder();
            _operationQueryBuilder = new OperationSaveQueryBuilder();
            _measurementQueryBuilder = new MeasurementSaveQueryBuilder();
            _patientCommandBuilder = new PatientSaveCommandBuilder();
            _operationCommandBuilder = new OperationSaveCommandBuilder();
            _patientInfoRetrieval = new PatientInfoRetrieval();
        }


        /// <summary>
        /// Saves bloodpressure data associated with the supplied patientDTO
        /// </summary>
        /// <param name="patient">PatientDTO holding the measurement values</param>
        public void SaveBloodPressureData(PatientDTO patient)
        {
            _measurementCommandBuilder = new MeasurementSaveCommandBuilder(patient.ListOperation[0].OperationsID);

            foreach (var maaling in patient.ListOperation[0].Maaling)
            {
                SaveMeasurementData(maaling, _measurementCommandBuilder);
            }
        }

        /// <summary>
        /// Saves measurement data
        /// </summary>
        /// <param name="maaling">Measurement data</param>
        /// <param name="cmdBuilder">The commandbuilder class used to create the sqlcommand</param>
        private void SaveMeasurementData(MaalingDTO maaling, ICommandBuilder<MaalingDTO> cmdBuilder)
        {
            var query = _measurementQueryBuilder.BuildQuery(maaling);

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {

                conn.Open();
                using (SqlCommand cmd = cmdBuilder.BuildCommand(maaling, conn, query))
                {
                    
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Saves initial data (patient and operation data) and saves the operation ID generated from the
        /// query
        /// </summary>
        /// <param name="patient">PatientDTO holding the data to be saved</param>
        public void InitialSave(PatientDTO patient)
        {
            if (_patientInfoRetrieval.HentData(patient).CPR == null)
            {
                InitalSavePatientData(patient);
            }
            InitialSaveOperationData(patient);
            _operationID = patient.ListOperation[0].OperationsID;
        }

        /// <summary>
        /// Saves initial patient data
        /// </summary>
        /// <param name="patient">PatientDTO holding the data to be saved</param>
        private void InitalSavePatientData(PatientDTO patient)
        {
            var patientQuery = _patientQueryBuilder.BuildQuery(patient);
            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = _patientCommandBuilder.BuildCommand(patient, conn, patientQuery))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Saves initial operation data
        /// </summary>
        /// <param name="patient">PatientDTO holding the data to be saved</param>
        private void InitialSaveOperationData(PatientDTO patient)
        {
            var operationQuery = _operationQueryBuilder.BuildQuery(patient.ListOperation[0]);

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = _operationCommandBuilder.BuildCommand(patient, conn, operationQuery))
                {
                    _operationID = (int) cmd.ExecuteScalar();
                    patient.ListOperation[0].OperationsID = _operationID;
                }
            }
        }
    }
}

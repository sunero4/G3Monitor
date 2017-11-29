using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DataAccessLogic.Gem;
using DataAccessLogic.Hent;
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
        private int _operationID;

        public DatabaseSaving()
        {
            _patientQueryBuilder = new PatientSaveQueryBuilder();
            _operationQueryBuilder = new OperationSaveQueryBuilder();
            _measurementQueryBuilder = new MeasurementSaveQueryBuilder();
            _patientCommandBuilder = new PatientSaveCommandBuilder();
            _operationCommandBuilder = new OperationSaveCommandBuilder();
        }


        public void SaveBloodPressureData(PatientDTO patient)
        {
            _measurementCommandBuilder = new MeasurementSaveCommandBuilder(_operationID);
            foreach (var maaling in patient.ListOperation[0].Maaling)
            {
                SaveMeasurementData(maaling, _measurementCommandBuilder);
            }

        }

        private void SaveMeasurementData(MaalingDTO maaling, ICommandBuilder<MaalingDTO> cmdBuilder)
        {
            var query = _measurementQueryBuilder.BuildQuery(maaling);

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = _measurementCommandBuilder.BuildCommand(maaling, conn, query))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void InitialSave(PatientDTO patient)
        {
            InitalSavePatientData(patient);
            InitialSaveOperationData(patient);
        }

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

        private void InitialSaveOperationData(PatientDTO patient)
        {
            var operationQuery = _operationQueryBuilder.BuildQuery(patient.ListOperation[0]);

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = _operationCommandBuilder.BuildCommand(patient, conn, operationQuery))
                {
                    _operationID = (int) cmd.ExecuteScalar();
                }
            }
        }
    }
}

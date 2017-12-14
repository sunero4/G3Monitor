using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    public class PatientInfoRetrieval : IRetrievedData<PatientDTO>
    {
        private PatientInfoCommandBuilder _commandBuilder;
        private PatientInfoQueryBuilder _queryBuilder;

        public PatientInfoRetrieval()
        {
            _commandBuilder = new PatientInfoCommandBuilder();
            _queryBuilder = new PatientInfoQueryBuilder();
        }
        /// <summary>
        /// Gets patient information for the patient with the corresponding CPR
        /// </summary>
        /// <param name="patient">PatientDTO holding the CPR</param>
        /// <returns>PatientDTO with retrieved information</returns>
        public PatientDTO HentData(PatientDTO patient)
        {
            var patientOut = new PatientDTO();
            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd = _commandBuilder.BuildCommand(patient, conn, _queryBuilder.BuildQuery(patient)))
                {
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            patientOut.CPR = patient.CPR;
                            patientOut.Fornavn = rdr.GetString(rdr.GetOrdinal("Fornavn"));
                            patientOut.Efternavn = rdr.GetString(rdr.GetOrdinal("Efternavn"));
                            patientOut.FindesData = true;
                        }
                    }
                }
            }
            return patientOut;
        }

    }
}

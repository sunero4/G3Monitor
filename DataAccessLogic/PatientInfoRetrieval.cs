using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class PatientInfoRetrieval : IRetrievedData
    {
        private PatientInfoCommandBuilder _commandBuilder;
        private PatientInfoQueryBuilder _queryBuilder;
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
                        }
                    }
                }
            }
            return patientOut;
        }

    }
}

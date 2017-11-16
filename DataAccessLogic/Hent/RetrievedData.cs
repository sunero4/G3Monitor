using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class RetrievedData :IRetrievedData<PatientDTO>
    {
        private ICommandBuilder<PatientDTO> _commandBuilder;
        private IQueryBuilder<PatientDTO> _queryBuilder;
        private PatientDTO _patient;

        public RetrievedData(PatientDTO patient)
        {
            _commandBuilder = new RetrievedCommandBuilder();
            _queryBuilder = new RetrievedQueryBuilder();
            _patient = patient;
        }

        public PatientDTO HentData()
        {
            PatientDTO patientOut = new PatientDTO() {ListMaalinger = new List<MaalingDTO>()};
            
            var query = _queryBuilder.BuildQuery(_patient);
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(_patient, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            MaalingDTO maaling = new MaalingDTO();
                            while (rdr.Read())
                            {
                                patientOut.CPR = rdr.GetString(rdr.GetOrdinal("CPR"));
                                patientOut.Fornavn = rdr.GetString(rdr.GetOrdinal("Fornavn"));
                                patientOut.Efternavn = rdr.GetString(rdr.GetOrdinal("Efternavn"));
                                maaling.MaaleData = (byte[]) rdr["Måledata"];
                                maaling.Kommentar = rdr.GetString(rdr.GetOrdinal("Kommentar"));
                                maaling.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt"));
                                
                                patientOut.ListMaalinger.Add(maaling);
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            return patientOut; 

        }

      

    }
}

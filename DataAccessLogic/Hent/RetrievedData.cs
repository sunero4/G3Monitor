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

        public RetrievedData()
        {
            _commandBuilder = new RetrievedCommandBuilder();
            _queryBuilder = new RetrievedQueryBuilder();
        }

        public PatientDTO HentData(PatientDTO patient)
        {
            PatientDTO patientOut = new PatientDTO() {ListOperation = new List<OperationsDTO>()};
            
            var query = _queryBuilder.BuildQuery(patient);
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(patient, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            OperationsDTO operation = new OperationsDTO(); 
                            while (rdr.Read())
                            {
                                patientOut.CPR = rdr.GetString(rdr.GetOrdinal("CPR"));
                                patientOut.Fornavn = rdr.GetString(rdr.GetOrdinal("Fornavn"));
                                patientOut.Efternavn = rdr.GetString(rdr.GetOrdinal("Efternavn"));
                                
                                //SS 
                                operation.Maaling[0].MaaleData = (byte[]) rdr["Måledata"];
                                operation.Kommentar = rdr.GetString(rdr.GetOrdinal("Kommentar"));
                                operation.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt")); 

                                patientOut.ListOperation.Add(operation); 
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

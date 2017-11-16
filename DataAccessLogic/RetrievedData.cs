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
    public class RetrievedData :IRetrievedData
    {
        private ICommandBuilder _commandBuilder;
        private IQueryBuilder _queryBuilder;


        public RetrievedData()
        {
            _commandBuilder = new RetrievedCommandBuilder();
            _queryBuilder = new RetrievedQueryBuilder();
        }

        public PatientDTO HentData(PatientDTO patient)
        {
            PatientDTO patientOut = new PatientDTO(){Maalinger = new MaalingDTO()};
           
            
            
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
                            while (rdr.Read())
                            {
                                patientOut.CPR = rdr.GetString(rdr.GetOrdinal("CPR"));
                                patientOut.Fornavn = rdr.GetString(rdr.GetOrdinal("Fornavn"));
                                patientOut.Efternavn = rdr.GetString(rdr.GetOrdinal("Efternavn"));
                                patientOut.Maalinger.MaaleData = (byte[])rdr["Måledata"];
                                patientOut.Maalinger.Kommentar = rdr.GetString(rdr.GetOrdinal("Kommentar"));
                                patientOut.Maalinger.MaaleTidspunkt = rdr.GetDateTime(rdr.GetOrdinal("Maaletidspunkt")); 
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

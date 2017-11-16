using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class RetrievedCommandBuilder: ICommandBuilder
    {
        public SqlCommand BuildCommand(PatientDTO patient, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@CPR", patient.CPR);

            return cmd;
        }


        
    }
}

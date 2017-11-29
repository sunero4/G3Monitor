using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class PatientSaveCommandBuilder : ICommandBuilder<PatientDTO>
    {
        public SqlCommand BuildCommand(PatientDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@fornavn", input.Fornavn);
            cmd.Parameters.AddWithValue("@efternavn", input.Efternavn);
            cmd.Parameters.AddWithValue("@cpr", input.CPR);

            return cmd;
        }
    }
}

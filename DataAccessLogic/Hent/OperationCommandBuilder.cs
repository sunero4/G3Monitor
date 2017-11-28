using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic.Hent
{
    public class OperationCommandBuilder : ICommandBuilder<PatientDTO>
    {
        public SqlCommand BuildCommand(PatientDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@cpr", input.CPR);

            return cmd;
        }
    }
}

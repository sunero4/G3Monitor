using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic.Hent
{
    public class MeasurementCommandBuilder : ICommandBuilder<OperationsDTO>
    {
        public SqlCommand BuildCommand(OperationsDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", input.OperationsID);

            return cmd;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class MeasurementSaveCommandBuilder : ICommandBuilder<MaalingDTO>
    {
        private int _operationID;

        public MeasurementSaveCommandBuilder(int operationId)
        {
            _operationID = operationId;
        }

        public SqlCommand BuildCommand(MaalingDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@operationsid", _operationID);
            cmd.Parameters.AddWithValue("@maaledata", input.MaaleData);
            cmd.Parameters.AddWithValue("@sekvensnummer", input.Sekvensnr);

            return cmd;
        }
    }
}

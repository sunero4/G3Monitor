using System.Data.SqlClient;
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

        /// <summary>
        /// Creates an sqlcommand with parameters matching values of the supplied DTO
        /// </summary>
        /// <param name="input">DTO holding values for parameters</param>
        /// <param name="conn">SQLConnection for the SQLCommand</param>
        /// <param name="query">Query for the command to execute</param>
        /// <returns>SQLCommand ready to execute</returns>
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

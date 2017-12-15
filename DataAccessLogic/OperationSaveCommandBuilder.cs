using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    public class OperationSaveCommandBuilder : ICommandBuilder<PatientDTO>
    {
        /// <summary>
        /// Creates an sqlcommand with parameters matching values of the supplied DTO
        /// </summary>
        /// <param name="input">OperationDTO holding values for parameters</param>
        /// <param name="conn">SQLConnection for the SQLCommand</param>
        /// <param name="query">Query for the command to execute</param>
        /// <returns>SQLCommand ready to execute</returns>
        public SqlCommand BuildCommand(PatientDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query,conn);

            cmd.Parameters.AddWithValue("@maaletidspunkt", input.ListOperation[0].MaaleTidspunkt);
            cmd.Parameters.AddWithValue("@kalibrering", input.ListOperation[0].Kalibrering);
            cmd.Parameters.AddWithValue("@nulpunktsjustering", input.ListOperation[0].Nulpunktjustering);
            cmd.Parameters.AddWithValue("@cpr", input.CPR);
            return cmd;
        }
    }
}

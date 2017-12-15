using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    public class SaveCommandBuilder : ICommandBuilder<PatientDTO>
    {
        /// <summary>
        /// Adds Sql parameters to an Sql command
        /// </summary>
        /// <param name="patient"> The patient dto that holds the values for the parameters</param>
        /// <param name="conn"> The Sql connection the command should be executed to</param>
        /// <param name="query"> The Sql query that the command should execute</param>
        /// <returns> An Sql command with added Sql parameters</returns>
        public SqlCommand BuildCommand(PatientDTO patient, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query, conn);

            //cmd.Parameters.AddWithValue("@cpr", patient.CPR);
            //cmd.Parameters.AddWithValue("@maaledata", patient.Maalinger.MaaleData);
            //cmd.Parameters.AddWithValue("@kommentar", patient.Maalinger.Kommentar);
            //cmd.Parameters.AddWithValue("@maaletidspunkt", patient.Maalinger.MaaleTidspunkt);

            return cmd;
        }


    }
}

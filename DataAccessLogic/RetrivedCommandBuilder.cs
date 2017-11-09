using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class RetrivedCommandBuilder : ICommandBuilderMedarbejder 
    {




        /// <summary>
        /// Aads SQl parameters to an SQL command 
        /// </summary>
        /// <param name="medarbejder">The patient dto that holds the values for the parameters</param> 
        /// <param name="conn">The Sql connection the command should be executed to</param>
        /// <param name="query">The Sql query that the command should execute</param>
        /// <returns>An Sql command with added Sql parameters</returns>
        public SqlCommand BuildCommand(MedarbejderDTO medarbejder, SqlConnection conn, string query)
            {
                var cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@brugernavn", medarbejder.Brugernavn);

                return cmd;
            }
        

    }
}

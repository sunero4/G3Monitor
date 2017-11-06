using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class SaveCommandBuilder : ICommandBuilder
    {
        /// <summary>
        /// Generates names for the parameters from patient properties
        /// </summary>
        /// <param name="patient">Patient dto object with properties to be used for the parameters</param>
        /// <returns></returns>
        public List<string> GetParameters(PatientDTO patient)
        {
            var parameters = new List<string>();

            Type type = patient.GetType();

            foreach (var property in type.GetProperties())
            {
                parameters.Add("@" + property.Name.ToLower());
            }

            return parameters;
        }

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
            var parameters = GetParameters(patient);

            Type type = patient.Maalinger.GetType();

            for (int i = 1, n = type.GetProperties().Length; i < n; i++)
            {
                cmd.Parameters.AddWithValue(parameters[i - 1], conn);
            }

            return cmd;
        }


    }
}

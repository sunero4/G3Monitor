using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class DatabaseSaving : ISaving
    {
        private ICommandBuilder<PatientDTO> _commandBuilder;
        private IQueryBuilder<PatientDTO> _queryBuilder;
        
        public DatabaseSaving()
        {
            _commandBuilder = new SaveCommandBuilder();
            _queryBuilder = new SaveQueryBuilder();
        }

        /// <summary>
        /// Saves data stored in the patient dto object in the database
        /// </summary>
        /// <param name="patient">Patient dto object containing the data to be saved</param>
        public void SaveBloodPressureData(PatientDTO patient)
        {
            var query = _queryBuilder.BuildQuery(patient);
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(patient, conn, query))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                //Find out how to handle sqlexceptions
            }
        }


    }
}

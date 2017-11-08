using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class RetrivedData : IRetrivedData
    {
        private ICommandBuilderMedarbejder _commandBuilder;
        private IQueryBuilderMedarbejder _queryBuilder;

        public RetrivedData()
        {
            _commandBuilder = new RetrivedCommandBuilder();
            _queryBuilder = new RetrivedQueryBuilder();
        }

        /// <summary>
        /// Retrieved data which matches medarbejder dto.brugernavn object in the database
        /// </summary>
        /// <param name="medarbejder"></param>
        /// <returns></returns>
        public MedarbejderDTO CheckLogin (MedarbejderDTO medarbejder)
        {
            var query = _queryBuilder.BuildQuery(medarbejder); 
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(medarbejder, conn, query))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            return medarbejder; 
        }
    }
}

        
    


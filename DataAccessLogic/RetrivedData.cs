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
        private ICommandBuilder _commandBuilder;
        private IQueryBuilderMedarbejder _queryBuilder;

        public RetrivedData()
        {
            _commandBuilder = new RetrivedCommandBuilder();
            _queryBuilder = new RetrivedQueryBuilder();
        }

        public MedarbejderDTO medarbejder()
        {
            var query = _queryBuilder.BuildQuery(medarbejder); // Anders 
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
                Console.WriteLine(e.Message)

    }
}

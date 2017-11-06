using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class RetrivedData : IRetrivedData
    {
        private ICommandBuilder _commandBuilder;
        private IQueryBuilder _queryBuilder;

        public RetrivedData()
        {
            _commandBuilder = new RetrivedCommandBuilder();
            _queryBuilder = new RetrivedQueryBuilder();
        }

        public MedarbejderDTO // Til line og Stine, enten skal vi lave metoden af en medarbejder DTO eller blot password
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
                Console.WriteLine(e.Message)

    }
}

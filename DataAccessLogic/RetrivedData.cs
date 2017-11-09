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
            MedarbejderDTO medarbejderOut;
            if (medarbejder.GetType() == new OPSygeplejerskeDTO().GetType())
            {
                medarbejderOut = new OPSygeplejerskeDTO();
            }
            else
            {
                medarbejderOut = new TeknikerDTO();
            }
            var query = _queryBuilder.BuildQuery(medarbejder); 
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(medarbejder, conn, query))
                    {
                        using (SqlDataReader rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                medarbejderOut.Brugernavn = rdr.GetString(rdr.GetOrdinal("Brugernavn"));
                                medarbejderOut.HashedPassword = (byte[]) rdr["HashedPassword"];
                            }


                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);

            }
            return medarbejderOut; 
        }
    }
}

        
    


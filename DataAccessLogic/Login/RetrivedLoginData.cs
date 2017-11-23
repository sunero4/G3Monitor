using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class RetrivedLoginData : IRetrivedLoginData
    {
        private ICommandBuilder<MedarbejderDTO> _commandBuilder;
        private IQueryBuilder<MedarbejderDTO> _queryBuilder;

        public RetrivedLoginData()
        {
            _commandBuilder = new RetrivedLoginCommandBuilder();
            _queryBuilder = new RetrivedLoginQueryBuilder("Temporary");
        }

        /// <summary>
        /// Retrieved data which matches medarbejder dto.brugernavn object in the database
        /// </summary>
        /// <param name="medarbejder"></param>
        /// <returns></returns>
        public MedarbejderDTO CheckLogin (MedarbejderDTO medarbejder)
        {
            MedarbejderDTO medarbejderOut;
            string tableName;
            if (medarbejder.GetType() == new OPSygeplejerskeDTO().GetType())
            {
                medarbejderOut = new OPSygeplejerskeDTO();
                tableName = "OPsygeplerjske"; 
            }
            else
            {
                medarbejderOut = new TeknikerDTO();
                tableName = "Tekniker"; 
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

        
    


using System;
using System.Data.SqlClient;
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
            _queryBuilder = new RetrivedLoginQueryBuilder("OPSygeplejerske");
        }

        /// <summary>
        /// Retrieved data which matches medarbejder dto.brugernavn object in the database
        /// </summary>
        /// <param name="medarbejder">The employee whose user information to retrieve</param>
        /// <returns>DTO holding the user information</returns>
        public MedarbejderDTO CheckLogin (MedarbejderDTO medarbejder)
        {
            MedarbejderDTO medarbejderOut;
            string tableName;

            //Decide which table to check
            if (medarbejder.GetType() == new OPSygeplejerskeDTO().GetType())
            {
                medarbejderOut = new OPSygeplejerskeDTO();
                tableName = "OPSygeplejerske"; 
            }
            else
            {
                medarbejderOut = new TeknikerDTO();
                tableName = "Tekniker";
                
            }
            _queryBuilder = new RetrivedLoginQueryBuilder(tableName);

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

        
    


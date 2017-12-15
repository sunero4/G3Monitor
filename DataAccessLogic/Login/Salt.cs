using System.Data.SqlClient;
using DTO;

namespace DataAccessLogic
{
    class Salt
    {
        /// <summary>
        /// Retrieves the salt corresponding to the supplied employee/user
        /// </summary>
        /// <param name="medarbejder">The employee whose salt bytes to retrieve</param>
        /// <returns>Salt as byte array</returns>
        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            string tableName = "";
            if (medarbejder.GetType() == new OPSygeplejerskeDTO().GetType())
            {
                tableName = "OPSygeplejerske";
            }
            else if(medarbejder.GetType() == new TeknikerDTO().GetType())
            {
                tableName = "Tekniker";
            }

            byte[] salt = new byte[32];

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("SELECT Salt FROM " + tableName +" WHERE Brugernavn = @brugernavn", conn))
                {
                    cmd.Parameters.AddWithValue("@brugernavn", medarbejder.Brugernavn);
                    using (SqlDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            salt = (byte[])rdr["Salt"];
                        }
                    }
                }
            }
            return salt;
        }
    }
}

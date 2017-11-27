using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class Salt
    {
        private SqlDataReader rdr; // Datalæseren
        private SqlCommand cmd;
        private const String dbKlinisk = "F17ST2ITS2201608531"; //Initial Catalog, User ID og PassWord til den locale Database

        //Property open connetion to local databse. 
        private SqlConnection OpenConnectionDatabase
        {
            get
            {
                var connLocal = new SqlConnection("Data Source=i4dab.ase.au.dk;Initial Catalog=" + dbKlinisk + ";Persist Security Info=True;User ID=" + dbKlinisk + ";Password=" + dbKlinisk + "");

                connLocal.Open();

                return connLocal;
            }
        }

        public byte[] GetSalt(MedarbejderDTO medarbejder)
        {
            byte[] salt = new byte[32];

            using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
            {
                conn.Open();
                using (SqlCommand cmd =
                    new SqlCommand("SELECT Salt FROM OPSygeplejerske WHERE Brugernavn = @brugernavn", conn))
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


            //    cmd = new SqlCommand("select Salt from OPSygeplejerske where Brugernavn =" + medarbejder.Brugernavn + "", OpenConnectionDatabase);
            //rdr = cmd.ExecuteReader(); //iterator løber det igennem

            //if (rdr.Read())
            //{
            //    salt = (byte[]) rdr["Salt"];
            //}
            //OpenConnectionDatabase.Close(); //lukker man en OpenConnection properti
            return salt;
        }
    }
}

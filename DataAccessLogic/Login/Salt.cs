using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
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
            
            cmd = new SqlCommand("select Salt from db_owner.OPsygeplejerske where Brugernavn =" + medarbejder.Brugernavn + "", OpenConnectionDatabase);
            rdr = cmd.ExecuteReader(); //iterator løber det igennem

            if (rdr.Read())
            {
                salt = (byte[]) rdr["Salt"];
            }
            OpenConnectionDatabase.Close(); //lukker man en OpenConnection properti
            return salt;
        }
    }
}

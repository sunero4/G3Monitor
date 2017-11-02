using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class LoginData
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

        // Login 
        //Metode der laver et opslag i den lokale databse i employee tabellen og tjekker om det id-nummer der er indsat i metoden findes i den lokale database.
        //derudover tjekker metoden også om id-nummeret er 6 cifre langt, som det skal være. Hvis begge betingelser er opfyldt returneres true ellers returneres false.
        public bool CheckLogin( OPSygeplejerskeDTO opSygeplejerske)
        {
            bool checkLogin = false;

            cmd = new SqlCommand("select * from db_owner.OPsygeplejerske where Brugernavn =" + opSygeplejerske.Brugernavn + "", OpenConnectionDatabase);
            cmd = new SqlCommand("select * from db_owner.OPsygeplejerske where HashedPassword =" + opSygeplejerske.HashedPassword + "", OpenConnectionDatabase);

            rdr = cmd.ExecuteReader(); //iterator løber det igennem

            if (rdr.Read() && opSygeplejerske.Brugernavn.Length==10)
            {
                return true; 
            }
            OpenConnectionDatabase.Close(); //lukker man en OpenConnection properti
            return checkLogin;
        }


    }
}

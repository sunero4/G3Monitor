using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class DatabaseSaving : ISaving
    {
        public void SaveBloodPressureData(PatientDTO patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(ConnectionInfo.SaveBloodPressureQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@cpr", patient.CPR);
                        cmd.Parameters.AddWithValue("@maaledata", patient.Maalinger.MaaleData);
                        cmd.Parameters.AddWithValue("@kommentar", patient.Maalinger.Kommentar);
                        cmd.Parameters.AddWithValue("@tidspunkt", patient.Maalinger.MaaleTidspunkt);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException e)
            {
                //Find out how to handle sqlexceptions
            }
        }


    }
}

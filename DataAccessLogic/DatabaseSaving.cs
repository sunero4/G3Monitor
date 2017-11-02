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
        private SaveCommandBuilder _commandBuilder;
        public void SaveBloodPressureData(PatientDTO patient)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionInfo.Connectionstring))
                {
                    conn.Open();
                    using (SqlCommand cmd = _commandBuilder.BuildCommand(patient, conn))
                    {
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

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    class SaveCommandBuilder : ICommandBuilder
    {
        private StringBuilder _builder;

        public SaveCommandBuilder()
        {
            _builder = new StringBuilder();
        }
        public SqlCommand BuildCommand(PatientDTO patient, SqlConnection conn)
        {
            var cmd = new SqlCommand(ConnectionInfo.SaveBloodPressureQuery, conn);
           
            cmd.Parameters.AddWithValue("@cpr", patient.CPR);
            cmd.Parameters.AddWithValue("@maaledata", patient.Maalinger.MaaleData);
            cmd.Parameters.AddWithValue("@kommentar", patient.Maalinger.Kommentar);
            cmd.Parameters.AddWithValue("@tidspunkt", patient.Maalinger.MaaleTidspunkt);

            return cmd;

        }


    }
}

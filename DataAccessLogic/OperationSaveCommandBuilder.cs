using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class OperationSaveCommandBuilder : ICommandBuilder<PatientDTO>
    {
        public SqlCommand BuildCommand(PatientDTO input, SqlConnection conn, string query)
        {
            var cmd = new SqlCommand(query,conn);

            cmd.Parameters.AddWithValue("@maaletidspunkt", input.ListOperation[0].MaaleTidspunkt);
            cmd.Parameters.AddWithValue("kommentar", input.ListOperation[0].Kommentar);
            cmd.Parameters.AddWithValue("@kalibrering", input.ListOperation[0].Kalibrering);
            cmd.Parameters.AddWithValue("@nulpunktsjustering", input.ListOperation[0].Nulpunktjustering);
            cmd.Parameters.AddWithValue("@cpr", input.CPR);
            cmd.Parameters.AddWithValue("@id", input.ListOperation[0].OperationsID);
            return cmd;
        }
    }
}

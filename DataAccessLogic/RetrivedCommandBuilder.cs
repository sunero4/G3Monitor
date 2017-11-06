using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class RetrivedCommandBuilder : ICommandBuilder
    {
        public SqlCommand BuildCommand(PatientDTO patient, SqlConnection conn, string query)
        {
            //fdkmfm
        }
       
    }
}

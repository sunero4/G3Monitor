using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class RetrivedCommandBuilder : ICommandBuilderMedarbejder 
    {
        public SqlCommand BuildCommand(MedarbejderDTO medarbejder, SqlConnection conn, string query)
        {
            //fdkmfm
        }
       
    }
}

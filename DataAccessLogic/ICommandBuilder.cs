using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public interface ICommandBuilder<T>
    {
        SqlCommand BuildCommand(T input, SqlConnection conn, string query);

    }
}

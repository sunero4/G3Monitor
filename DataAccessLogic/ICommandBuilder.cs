using System.Data.SqlClient;

namespace DataAccessLogic
{
    public interface ICommandBuilder<T>
    {

        /// <summary>
        /// Creates an sqlcommand with parameters matching values of the supplied DTO
        /// </summary>
        /// <param name="input">OperationDTO holding values for parameters</param>
        /// <param name="conn">SQLConnection for the SQLCommand</param>
        /// <param name="query">Query for the command to execute</param>
        /// <returns>SQLCommand ready to execute</returns>
        SqlCommand BuildCommand(T input, SqlConnection conn, string query);

    }
}

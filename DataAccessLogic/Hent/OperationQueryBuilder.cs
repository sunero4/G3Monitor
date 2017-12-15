using System.Collections.Generic;
using System.Text;
using DTO;

namespace DataAccessLogic.Hent
{
    public class OperationQueryBuilder : IQueryBuilder<List<OperationsDTO>>
    {
        private StringBuilder _stringBuilder;

        public OperationQueryBuilder()
        {
            _stringBuilder = new StringBuilder();
        }

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">DTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(List<OperationsDTO> input)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append("SELECT * FROM OperationsData WHERE CPR = @cpr");
            return _stringBuilder.ToString();
        }
    }
}

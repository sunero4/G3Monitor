using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string BuildQuery(List<OperationsDTO> input)
        {
            _stringBuilder.Append("SELECT * FROM OperationsData WHERE CPR = @cpr");
            return _stringBuilder.ToString();
        }
    }
}

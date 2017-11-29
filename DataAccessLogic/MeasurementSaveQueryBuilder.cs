using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class MeasurementSaveQueryBuilder : IQueryBuilder<MaalingDTO>
    {
        private StringBuilder _stringBuilder;

        public MeasurementSaveQueryBuilder()
        {
            _stringBuilder = new StringBuilder();
        }

        public string BuildQuery(MaalingDTO input)
        {
            _stringBuilder.Append("INSERT INTO Maaling (OperationsID, Maaledata) VALUES (@operationsid, @maaledata");

            return _stringBuilder.ToString();
        }
    }
}

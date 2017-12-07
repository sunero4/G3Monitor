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
            _stringBuilder.Clear();
            _stringBuilder.Append("INSERT INTO Måling (OperationsID, Maaledata, SekvensNummer) VALUES (@operationsid, @maaledata, @sekvensnummer)");

            return _stringBuilder.ToString();
        }
    }
}

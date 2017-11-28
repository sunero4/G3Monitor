using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic.Hent
{
    public class MeasurementQueryBuilder : IQueryBuilder<PatientDTO>
    {
        private StringBuilder _stringBuilder;

        public MeasurementQueryBuilder()
        {
            _stringBuilder = new StringBuilder();
        }


        public string BuildQuery(PatientDTO input)
        {
            _stringBuilder.Append("SELECT * FROM Maaling WHERE MaaleID = @id");
            return _stringBuilder.ToString();
        }
    }
}

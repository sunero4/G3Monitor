using System.Text;
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

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">DTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(PatientDTO input)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append("SELECT * FROM Måling WHERE OperationsId = @id");
            return _stringBuilder.ToString();
        }
    }
}

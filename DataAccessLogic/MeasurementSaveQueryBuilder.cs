using System.Text;
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

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">DTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(MaalingDTO input)
        {
            _stringBuilder.Clear();
            _stringBuilder.Append("INSERT INTO Måling (OperationsID, Maaledata, SekvensNummer) VALUES (@operationsid, @maaledata, @sekvensnummer)");

            return _stringBuilder.ToString();
        }
    }
}

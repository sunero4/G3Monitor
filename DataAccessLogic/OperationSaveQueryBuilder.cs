using System.Text;
using DTO;

namespace DataAccessLogic
{
    public class OperationSaveQueryBuilder : IQueryBuilder<OperationsDTO>
    {
        private StringBuilder _stringBuilder;
        public OperationSaveQueryBuilder()
        {
            _stringBuilder = new StringBuilder();
        }

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">DTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(OperationsDTO input)
        {
            _stringBuilder.Clear();

            _stringBuilder.Append(
                "INSERT INTO OperationsData (Maaletidspunkt, Kalibrering, Nulpunktsjustering, CPR) OUTPUT INSERTED.OperationsID VALUES (@maaletidspunkt, @kalibrering, @nulpunktsjustering, @cpr)");

            return _stringBuilder.ToString();
        }
    }
}

using System.Text;
using DTO;

namespace DataAccessLogic
{
    public class PatientInfoQueryBuilder : IQueryBuilder<PatientDTO>
    {
        private StringBuilder _builder;

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">DTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(PatientDTO patient)
        {
            _builder = new StringBuilder();

            _builder.Append("SELECT Fornavn, Efternavn FROM Patient WHERE CPR = @cpr");

            return _builder.ToString();
        }
    }
}

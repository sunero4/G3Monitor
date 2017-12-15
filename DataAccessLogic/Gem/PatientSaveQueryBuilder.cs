using System.Text;
using DTO;

namespace DataAccessLogic.Gem
{
    public class PatientSaveQueryBuilder : IQueryBuilder<PatientDTO>
    {
        private StringBuilder _builder;

        public PatientSaveQueryBuilder()
        {
            _builder = new StringBuilder();

        }

        /// <summary>
        /// Returns an SQL query
        /// </summary>
        /// <param name="input">PatientDTO</param>
        /// <returns>SQL query</returns>
        public string BuildQuery(PatientDTO input)
        {
            _builder.Clear();
            _builder.Append("INSERT INTO Patient (Fornavn, Efternavn, CPR) VALUES (@fornavn, @efternavn, @cpr)");

            return _builder.ToString();
        }
    }
}

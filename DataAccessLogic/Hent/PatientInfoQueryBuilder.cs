using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class PatientInfoQueryBuilder : IQueryBuilder
    {
        private StringBuilder _builder;
        public string BuildQuery(PatientDTO patient)
        {
            _builder = new StringBuilder();

            _builder.Append("SELECT Fornavn, Efternavn FROM Patient WHERE CPR = @cpr");

            return _builder.ToString();
        }
    }
}

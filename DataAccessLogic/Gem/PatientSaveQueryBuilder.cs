using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
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

        public string BuildQuery(PatientDTO input)
        {
            _builder.Clear();
            _builder.Append("INSERT INTO Patient (Fornavn, Efternavn, CPR) VALUES (@fornavn, @efternavn, @cpr)");

            return _builder.ToString();
        }
    }
}

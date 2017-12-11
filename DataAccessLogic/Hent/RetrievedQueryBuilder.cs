using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace DataAccessLogic
{
    public class RetrievedQueryBuilder :IQueryBuilder<PatientDTO>
    {
        private StringBuilder _builder;

        public string BuildQuery(PatientDTO patient)
        {

            _builder = new StringBuilder();
            _builder.Clear();
            _builder.Append("select Patient.Fornavn, Patient.Efternavn, Patient.CPR, Maalinger.MaaleId, Maalinger.Måledata, Maalinger.Kommentar, Maalinger.Maaletidspunkt from Patient inner join Maalinger on Patient.CPR = Maalinger.CPR");
            return _builder.ToString();
        }

    }  
}


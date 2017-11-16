using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public class SaveQueryBuilder : IQueryBuilder
    {
        private StringBuilder _builder;
        public string Tablename { get; set; }
        public List<string> ColumnNames { get; set; }

        public SaveQueryBuilder()
        {
            Tablename = "Maaling";
            ColumnNames = new List<string>() {"CPR", "Måledata", "Kommentar", "Maaletidspunkt"};
        }

        /// <summary>
        /// Builds an Sql INSERT query from a predefined list of columnnames
        /// </summary>
        /// <param name="patient">Patient dto object with properties to be used for naming parameters</param>
        /// <returns>Sql INSERT query</returns>
        public string BuildQuery(PatientDTO patient)
        {
            _builder = new StringBuilder();
            _builder.Append("INSERT INTO " + Tablename + "(");

            for (int i = 0, n = ColumnNames.Count; i < n; i++)
            {
                if (i < n - 1)
                    _builder.Append(ColumnNames[i] + ", ");
                if (i == n - 1)
                    _builder.Append(ColumnNames[i] + ") ");
            }
            _builder.Append("VALUES (@cpr, @maaledata, @kommentar, @maaletidspunkt)");

            return _builder.ToString();
        }
    }
}

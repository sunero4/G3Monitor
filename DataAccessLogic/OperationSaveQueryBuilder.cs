using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public string BuildQuery(OperationsDTO input)
        {
            _stringBuilder.Append(
                "INSERT INTO OperationsData (Maaletidspunkt, Kommentar, Kalibrering, Nulpunktsjustering, CPR, OperationsID) OUTPUT INSERTED.OperationsID VALUES (@maaletidspunkt, @kommentar, @kalibrering, @nulpunktsjustering, @cpr, @id)");

            return _stringBuilder.ToString();
        }
    }
}

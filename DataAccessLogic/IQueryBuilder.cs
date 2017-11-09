using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    public interface IQueryBuilder
    {
        string BuildQuery(PatientDTO patient);
    }
}

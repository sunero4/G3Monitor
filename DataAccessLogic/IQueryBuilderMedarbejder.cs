using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DataAccessLogic
{
    interface IQueryBuilderMedarbejder
    {
        string BuildQuery(MedarbejderDTO medarbejder);
    }
}

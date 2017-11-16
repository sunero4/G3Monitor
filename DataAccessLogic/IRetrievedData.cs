using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    public interface IRetrievedData<T>
    {
        T HentData();
    }
}

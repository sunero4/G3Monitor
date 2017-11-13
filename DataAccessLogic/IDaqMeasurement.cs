using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLogic
{
    //Interface for mocking purposes and to be able to distinguish between measuring for adjustment and
    //measuring real bloodpressure values, as separate logic is to be used
    public interface IDaqMeasurement
    {
        double GetVoltage();

    }
}

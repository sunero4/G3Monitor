using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic
{
    class DataConverter
    {
        public List<double> ConvertArrayToDoubles(byte[] maaledata)
        {
            double[] darray = new double[maaledata.Length / sizeof(double)];
            Buffer.BlockCopy(maaledata, 0, darray, 0, maaledata.Length);
            return darray.ToList<double>();
        }
    }
}

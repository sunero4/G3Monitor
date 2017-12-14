using System;
using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic
{
    public class DataConverter
    {
        /// <summary>
        /// Converts from byte array to list of doubles
        /// </summary>
        /// <param name="maaledata">Data to convert</param>
        /// <returns>Converted data</returns>
        public static List<double> ConvertArrayToDoubles(byte[] maaledata)
        {
            double[] darray = new double[maaledata.Length / sizeof(double)];
            Buffer.BlockCopy(maaledata, 0, darray, 0, maaledata.Length);
            return darray.ToList<double>();
        }

        /// <summary>
        /// Converts from list of doubles to byte array
        /// </summary>
        /// <param name="data">Data to convert</param>
        /// <returns>Converted data</returns>
        public static byte[] ConvertDoublesToByteArray(List<double> data)
        {
            var array = data.ToArray();
            return array.SelectMany(x => BitConverter.GetBytes(x)).ToArray();
        }
    }
}

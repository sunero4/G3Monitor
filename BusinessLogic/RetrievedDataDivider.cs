using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace BusinessLogic
{
    class RetrievedDataDivider
    {

        private MaalingDTO _MaalingDto;
        public List<MaalingDTO> RetrievedDivider(byte[] bpValues)
        {
            List<MaalingDTO> list = new List<MaalingDTO>();
            int counter = 0;
       
            byte[] temp = new byte[5000 * sizeof(double)];
            for (int i = 0, n = bpValues.Length; i < n; i++)
            {
                if (counter == 5000 * sizeof(double))
                {
                    list.Add(new MaalingDTO() {MaaleData = temp});
                    Array.Clear(temp, 0, temp.Length - 1);
                    counter = 0;
                }

                temp[i] = bpValues[i];
                counter++;
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class CPRChecker
    {
        //Metode til at tjekke gyldigheden af CPR-nr: 
        public bool CPRchecker(string cprnr)
        {
            int[] array = new int[10];

            if (array.Length != 10)
            {
                return false;
            }

            if (cprnr.Length != 10)
            {
                return false;
            }

            for (int counter = 0; counter < array.Length; counter++)
            {
                array[counter] = Convert.ToInt32(cprnr[counter]) - 48;
            }
            int Resultat = (4 * array[0] + 3 * array[1] + 2 * array[2] + 7 * array[3] + 6 * array[4] + 5 * array[5] + 4 * array[6] + 3 * array[7] + 2 * array[8] + array[9]) % 11;

            if (Resultat == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

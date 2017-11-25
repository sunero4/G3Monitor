using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogic.Filter;
using DTO;
using ObserverPattern;

namespace BusinessLogic
{
    public class Filtering 
    {
        public static IFilter CreatFilter(string description)
        {
            if (description == "Filter")
            {
                IFilter filter = new Filter();
                return filter;
            }
            if (description == "AndetFilter")
            {
                IFilter rawFilter = new RawFilter();
                return rawFilter;
            }
            else
            {
                throw new Exception("Fejl");
            }
        }
        //Tilføjer kalibrering og nulpunktsjustering 
        public List<double> AddFactor(List<data> containerData)
        {

            double kali = new KalibreringsDTO().Slope;
            double nul = new NulpunktsjusteringDTO().Nulpunktsjustering;
            for (int i = 0; i < containerData.Count; i++)
            {
                kali = kali * containerData[i];
                nul = nul * kali;
            }

            return List<>;
        }

    }
    
}

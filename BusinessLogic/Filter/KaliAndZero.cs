using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Accord.Math;
using Interfaces;
using MathNet.Filtering;
using MathNet.Filtering.IIR;
using MathNet.Numerics;


namespace BusinessLogic.Filter
{
    public class KaliAndZero
    {
        private NulpunktsjusteringDTO _nulpunkt;
        private KalibreringsDTO _kalibrering;

        public KaliAndZero(NulpunktsjusteringDTO nulpunkt, KalibreringsDTO kalibrering)
        {
            _nulpunkt = nulpunkt;
            _kalibrering = kalibrering;
        }

        //Tilføjer kalibrering og nulpunktsjustering. Og Fjerner netstøj. 
        public List<double> AddKalibreringAndZero(List<double> containerData)
        {
            //double nul = _nulpunkt.Nulpunktsjustering;
            var nul = 0;
            double kali = _kalibrering.Slope;
            for (int i = 0; i < containerData.Count; i++)
            {
                containerData[i] = kali * containerData[i] + nul;
            }
            return containerData;
        }
    


    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NulpunktsjusteringDTO
    {
        private double _nulpunktsjustering;

        public double Nulpunktsjustering
        {
            get => _nulpunktsjustering;
            set   
            {
                if (value > 0)
                {
                    _nulpunktsjustering = value;
                    // Skriv andre evt restriktioner 
                }
            }
        }
    }

}

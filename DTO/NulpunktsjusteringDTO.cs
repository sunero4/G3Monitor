using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NulpunktsjusteringDTO
    {
        private int _nulpunktsjustering;

        public int Nulpunktsjustering
        {
            get => _nulpunktsjustering;
            set   
            {
                if (value > 0)
                {
                    Nulpunktsjustering = value;
                    // Skriv andre evt restriktioner 
                }
            }
        }
    }
    }
}

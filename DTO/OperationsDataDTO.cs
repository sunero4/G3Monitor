using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class OperationsDTO
    {
        private string _kommentar;
        public List<MaalingDTO> Maaling { get; set; }
        public double Kalibrering { get; set; }
        public double Nulpunktjustering { get; set; }
        public int OperationsID { get; set; }
        
        
        public string Kommentar
        {
            get => _kommentar;
            set
            {
                if (value.Length <= 500)
                {
                    _kommentar = value;
                }
            }
        }

        public DateTime MaaleTidspunkt { get; set; }
    }
}

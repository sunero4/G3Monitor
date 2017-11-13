using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KalibreringsDTO
    {
        public List<int> ExpectedValue { get; set; }
        public List<int> ActualValue { get; set; }
        public DateTime Time { get; set; }
        public string Technician { get; set; }

        private double _slope;
        public double Slope
        {
            get => _slope;
            set => _slope = value;
        }

        private double _intercept;
        public double Intercept
        {
            get => _intercept;
            set => _intercept = value;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Monitoreringsindstillinger
    {
        private int _miminumSystolic;
        private int _maximumSystolic;
        private int _minimumDiastolic;
        private int _maximumDiastolic;

        public int MinimumSystolic
        {
            get => _miminumSystolic;
            set
            {
                if (value > 0)
                {
                    _miminumSystolic = value;
                }
            }
        }
        public int MaximumSystolic
        {
            get => _maximumSystolic;
            set
            {
                if (value > 0)
                {
                    _maximumSystolic = value;
                }
            }
        }
        public int MinimumDiastolic
        {
            get => _minimumDiastolic;
            set
            {
                if (value > 0)
                {
                    _minimumDiastolic = value;
                }
            } }
        public int MaximumDiastolic
        {
            get => _maximumDiastolic;
            set
            {
                if (value > 0)
                {
                    _maximumDiastolic = value;
                }
            } }
        public bool Saving { get; set; }
        public PatientDTO Patient { get; set; }
    }
}

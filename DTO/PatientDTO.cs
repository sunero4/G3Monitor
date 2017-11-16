using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PatientDTO
    {
        private string _cpr;
        private string _fornavn;
        private string _efternavn;

        public string CPR
        {
            get => _cpr;
            set
            {
                if (value.Length == 10)
                {
                    _cpr = value;
                }
            }
        }

        public string Fornavn
        {
            get => _fornavn;
            set
            {
                if (value.Length <= 20)
                {
                    _fornavn = value;
                }
            }
        }

        public string Efternavn
        {
            get => _efternavn;
            set
            {
                if (value.Length <= 25)
                {
                    _efternavn = value;
                }
            }
        }

        public MaalingDTO Maalinger { get; set; }

        public bool FindesData { get; set; } = true; 
    }
}

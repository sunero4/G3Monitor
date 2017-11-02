using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class OPSygeplejerskeDTO
    {
        private string _brugernavn;
        public string Brugernavn
        {
            get => _brugernavn;
            set
            {
                if (value.Length == 10)
                {
                    _brugernavn = value;
                }
            }
        }

        public byte[] HashedPassword { get; set; }

        public byte[] Salt { get; set; }

    }
}

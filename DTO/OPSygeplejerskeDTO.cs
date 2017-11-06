using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DTO
{
    public class OPSygeplejerskeDTO : MedarbejderDTO
    {
        private string _brugernavn;
        public override string Brugernavn
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

        public override byte[] HashedPassword { get; set; }     

        public override byte[] Salt { get; set; }

    }
}

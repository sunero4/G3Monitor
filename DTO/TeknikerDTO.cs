using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TeknikerDTO : MedarbejderDTO
    {
        private string _brugernavn;
        public override string Brugernavn
        {
            get => _brugernavn;
            set
            {
                if (value.Length == 8)
                {
                    _brugernavn = value;
                }
            }
        }

        public override byte[] HashedPassword { get; set; }

        public override byte[] Salt { get; set; }
    }
}

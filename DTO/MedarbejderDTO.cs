using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public abstract class MedarbejderDTO
    {
        public abstract string Brugernavn { get; set; }
       
        public abstract byte[] HashedPassword { get; set; }

        public abstract byte[] Salt { get; set; }
    }
}

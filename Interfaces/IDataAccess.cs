using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace Interfaces
{
    public interface IDataAccess
    {
        MedarbejderDTO CheckLogin(MedarbejderDTO medarbejder);


        byte[] GetSalt(MedarbejderDTO medarbejder);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using DTO;
using Interfaces;

namespace BusinessLogic
{
    class Login
    {
        // Lav en metode der tjekker om første parameter er lig anden parameter (DTO parameter med retrieved data) 
        // herved tjekker vi om der findes en bruger og om password eksitere 

        //private MedarbejderDTO _medarbejder2; 
        private IDataAccess _iDataAccess; 
        public Login(MedarbejderDTO medarbejder, /*MedarbejderDTO medarbejder2*/ IDataAccess iDataAccess)
        {
            _iDataAccess = iDataAccess; 
        }
        public bool CheckLogin(MedarbejderDTO medarbejder, MedarbejderDTO medarbejder2)
        {
            if (medarbejder.Brugernavn == medarbejder2.Brugernavn && medarbejder.HashedPassword == medarbejder2.HashedPassword)
            {
                return true; 
            }
            else
            {
                return false;
            }
            

        }
    }
}

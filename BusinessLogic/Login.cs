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
    public class Login
    {
        // Lav en metode der tjekker om første parameter er lig anden parameter (DTO parameter med retrieved data) 
        // herved tjekker vi om der findes en bruger og om password eksitere 
  
        public bool CheckLogin(MedarbejderDTO medarbejder, MedarbejderDTO medarbejder2)
        {
            if (medarbejder.Brugernavn == medarbejder2.Brugernavn && medarbejder.HashedPassword.SequenceEqual(medarbejder2.HashedPassword))
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

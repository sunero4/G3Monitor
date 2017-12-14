using System.Linq;
using DTO;

namespace BusinessLogic
{
    public class Login
    {

  
        /// <summary>
        /// Verifies whether the supplied login information matches a user in the database
        /// </summary>
        /// <param name="medarbejder">DTO holding the entered login values</param>
        /// <param name="medarbejder2">DTO holding login information retrieved from the database</param>
        /// <returns>True if username and password match, false otherwise</returns>
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

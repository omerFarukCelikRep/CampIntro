using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.DateOfBirth.Year == 1990 && gamer.FirstName == "Ömer Faruk" && gamer.LastName == "Çelik" && gamer.IdentityNumber == 12345679801)
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

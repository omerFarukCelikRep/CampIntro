using GameProject.Adapters;
using GameProject.Concrete;
using GameProject.Entities;
using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            //GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(new Gamer
            {
                ID = 1,
                FirstName = "Ömer Faruk",
                LastName = "Çelik",
                DateOfBirth = new DateTime(1990, 1, 1),
                IdentityNumber = 12345679801
            });
        }
    }
}

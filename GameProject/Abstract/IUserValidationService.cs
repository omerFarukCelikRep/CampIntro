using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Adapters
{
    public interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear==2001 && gamer.FirstName=="Emircan" && gamer.LastName=="Yılmaz" && gamer.IdentityNumber==12345)
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

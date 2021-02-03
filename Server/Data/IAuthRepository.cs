﻿using Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Data 
{
    public interface IAuthRepository
    {
  
        Task<ServiceResponse<string>> Login(string email, string password);

        Task<bool> UserExists(string email);
    }
}

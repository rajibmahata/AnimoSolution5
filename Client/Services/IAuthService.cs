using Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Client.Services
{ 
    public interface IAuthService
    { 
      
        Task<ServiceResponse<string>> Login(UserLogin req);  
    }
}

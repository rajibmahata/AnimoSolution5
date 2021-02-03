using Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Services 
{
    public interface IUtilityService
    {
        Task<Users> GetUser(); 
    }
}

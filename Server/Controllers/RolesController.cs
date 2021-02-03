using AnimoWeb.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {

        private readonly ApplicationDbContext context;   
        public RolesController(ApplicationDbContext context) 
        {
            this.context = context;            
        }


         

        [HttpGet]
        public async Task<ActionResult<List<Roles>>> Get()
        {
            return await context.Roles.ToListAsync();
        }


    }
}

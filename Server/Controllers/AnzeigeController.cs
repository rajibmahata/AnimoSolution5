using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnzeigeController : ControllerBase
    {

        private readonly ApplicationDbContext context;    
    

        public AnzeigeController(ApplicationDbContext context) 
        {
            this.context = context; 
        }

        [HttpGet]
        public async Task<ActionResult<Bilboard>> Get()
        {
            var bilboard = await context.Bilboards.Where(x => x.isDefaultActive == true).FirstOrDefaultAsync();

            if (bilboard == null)
            {
                return NotFound();
            }
            return bilboard;
        }



    }
}

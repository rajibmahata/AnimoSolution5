using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared;
using Model.Shared.DTOs;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TecnosController : ControllerBase
    {
        private readonly ApplicationDbContext context;     
        public TecnosController(ApplicationDbContext context) 
        {            this.context = context;           }




        [HttpGet]
        public async Task<ActionResult<List<Tecnos>>> Get([FromQuery] Paginacion paginacion )
        {
            var queryable = context.Tecnos.OrderBy(x => x.TecnoName).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }        
        
        
        
        [HttpGet("{TecnoId}")]
        public async Task<ActionResult<Tecnos>> Get(int TecnoId)
        {
            return await context.Tecnos.FirstOrDefaultAsync(x => x.TecnoId == TecnoId);
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Tecnos tecno)
        {            
            context.Add(tecno);
            await context.SaveChangesAsync();
            return tecno.TecnoId;
        }

        [HttpPut]
        public async Task<ActionResult> Put(Tecnos tecno)
        {
            context.Attach(tecno).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return NoContent();
        }


        [HttpDelete("{TecnoId}")]
        public async Task<IActionResult> Delete(int TecnoId)
        {
            var tecnos = await context.Tecnos.FindAsync(TecnoId);
            if (tecnos == null)
            {
                return NotFound();
            }

            context.Tecnos.Remove(tecnos);
            await context.SaveChangesAsync();

            return NoContent();
        }        

    }
}

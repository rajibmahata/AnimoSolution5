using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared.Entities;
using Model.Shared.DTOs;
using AnimoWeb.Server.Helpers;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlobalLocationsController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GlobalLocationsController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<GlobalLocations>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.GlobalLocations.OrderBy(x => x.LocationReference).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<GlobalLocations>> Get(int id)
        {
            var globalLocations = await context.GlobalLocations.FindAsync(id);

            if (globalLocations == null)
            {
                return NotFound();
            }

            return globalLocations;
        }


        [HttpPut]
        public async Task<IActionResult> Put(GlobalLocations globalLocations)
        {
            var id = globalLocations.Id;
            if (id != globalLocations.Id)
            {
                return BadRequest();
            }

            context.Entry(globalLocations).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlobalLocationsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(GlobalLocations globalLocations)
        {
            context.GlobalLocations.Add(globalLocations);
            await context.SaveChangesAsync();

            return globalLocations.Id;
        }

      
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var globalLocations = await context.GlobalLocations.FindAsync(id);
            if (globalLocations == null)
            {
                return NotFound();
            }

            context.GlobalLocations.Remove(globalLocations);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlobalLocationsExists(int id)
        {
            return context.GlobalLocations.Any(e => e.Id == id);
        }
    }
}

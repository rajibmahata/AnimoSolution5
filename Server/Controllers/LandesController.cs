using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LandesController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public LandesController(ApplicationDbContext context)
        {
            this.context = context;
        }


        [HttpGet]
        public async Task<ActionResult<List<Landes>>> Get()
        {
            return await context.Landes.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Landes>> Get(int id)
        {
            var landes = await context.Landes.FindAsync(id);

            if (landes == null)
            {
                return NotFound();
            }

            return landes;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, Landes landes)
        {
            if (id != landes.LandeId)
            {
                return BadRequest();
            }

            context.Entry(landes).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LandesExists(id))
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
        public async Task<ActionResult<Landes>> Post(Landes landes)
        {
            context.Landes.Add(landes);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetLandes", new { id = landes.LandeId }, landes);
        }

      
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var landes = await context.Landes.FindAsync(id);
            if (landes == null)
            {
                return NotFound();
            }

           context.Landes.Remove(landes);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool LandesExists(int id)
        {
            return context.Landes.Any(e => e.LandeId == id);
        }
    }
}

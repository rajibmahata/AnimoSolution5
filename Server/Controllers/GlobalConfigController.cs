using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared;
using Microsoft.AspNetCore.Authorization;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class GlobalConfigController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public GlobalConfigController(ApplicationDbContext context)
        {
            this.context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<GlobalConfig>> GetGlobalConfig()
        {
            var config = await context.GlobalConfig.FirstOrDefaultAsync();

            if(config == null)
            {
                return NotFound();
            }

            return Ok(config);



        }

       
        [HttpGet("{id}")]
        public async Task<ActionResult<GlobalConfig>> GetGlobalConfig(int id)
        {
            var globalConfig = await context.GlobalConfig.FindAsync(id);

            if (globalConfig == null)
            {
                return NotFound();
            }

            return globalConfig;
        }

        [HttpPut]
        public async Task<IActionResult> Put(GlobalConfig globalConfig) 
        {
            var id = globalConfig.Id;
            if (id != globalConfig.Id)
            {
                return BadRequest();
            }

            context.Entry(globalConfig).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlobalConfigExists(id))
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
        public async Task<ActionResult<GlobalConfig>> PostGlobalConfig(GlobalConfig globalConfig)
        {
            context.GlobalConfig.Add(globalConfig);
            await context.SaveChangesAsync();

            return CreatedAtAction("GetGlobalConfig", new { id = globalConfig.Id }, globalConfig);
        }

     
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlobalConfig(int id)
        {
            var globalConfig = await context.GlobalConfig.FindAsync(id);
            if (globalConfig == null)
            {
                return NotFound();
            }

            context.GlobalConfig.Remove(globalConfig);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlobalConfigExists(int id)
        {
            return context.GlobalConfig.Any(e => e.Id == id);
        }
    }
}

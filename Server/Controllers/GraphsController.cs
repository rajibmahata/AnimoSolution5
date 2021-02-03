using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared;
using AnimoWeb.Server.Helpers;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GraphsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "NewsGraphics";
        public GraphsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        { this.context = context; this.almacenadorArchivos = almacenadorArchivos; }

        
        [HttpGet]
        public async Task<ActionResult<List<Graphs>>> GetGraphs()
        {
            return await context.Graphs.ToListAsync();
        }


        [HttpGet("{GraphId}")]
        public async Task<ActionResult<Graphs>> Get(int GraphId)
        {
            var graphs = await context.Graphs.FindAsync(GraphId);

            if (graphs == null)
            {
                return NotFound();
            }

            return graphs;
        }


        [HttpPut]
        public async Task<ActionResult> Put(Graphs graphs)
        {
            var GraphId = graphs.GraphId;
            if (GraphId != graphs.GraphId)
            {
                return BadRequest();
            }

            context.Entry(graphs).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GraphsExists(GraphId))
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
        public async Task<ActionResult<int>> Post(Graphs graphs)
        {
            if (!string.IsNullOrEmpty(graphs.GraphUrl))
            {
                var posterProject = Convert.FromBase64String(graphs.GraphUrl);
                graphs.GraphUrl = await almacenadorArchivos.GuardarArchivo(posterProject, "jpg", contenedor);

            }
            // sincrono
            try
            {
                context.Graphs.Add(graphs);
                context.SaveChanges();
            }
            catch (Exception x)
            {
                var err = x.Message;
            }
            

            return graphs.GraphId;
        }

 
        [HttpDelete("{GraphId}")]
        public async Task<ActionResult> Delete(int GraphId)
        {
            var graphs = await context.Graphs.FindAsync(GraphId);
            if (graphs == null)
            {
                return NotFound();
            }

            context.Graphs.Remove(graphs);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool GraphsExists(int GraphId)
        {
            return context.Graphs.Any(e => e.GraphId == GraphId);
        }
    }
}

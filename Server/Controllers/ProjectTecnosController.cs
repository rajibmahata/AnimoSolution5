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
    public class ProjectTecnosController : ControllerBase
    {
        private readonly ApplicationDbContext context;

        public ProjectTecnosController(ApplicationDbContext context)
        {
            this.context = context;
        }

      
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProjectTecnos>>> GetProjectTecnos()
        {
            return await context.ProjectTecnos.ToListAsync();
        }

    
        [HttpGet("{id}")]
        public async Task<ActionResult<ProjectTecnos>> GetProjectTecnos(int id)
        {
            var projectTecnos = await context.ProjectTecnos.FindAsync(id);

            if (projectTecnos == null)
            {
                return NotFound();
            }

            return projectTecnos;
        }

  
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProjectTecnos(int id, ProjectTecnos projectTecnos)
        {
            if (id != projectTecnos.ProjectId)
            {
                return BadRequest();
            }

            context.Entry(projectTecnos).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProjectTecnosExists(id))
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
        public async Task<ActionResult<ProjectTecnos>> PostProjectTecnos(ProjectTecnos projectTecnos)
        {
            context.ProjectTecnos.Add(projectTecnos);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ProjectTecnosExists(projectTecnos.ProjectId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetProjectTecnos", new { id = projectTecnos.ProjectId }, projectTecnos);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectTecnos(int id)
        {
            var projectTecnos = await context.ProjectTecnos.FindAsync(id);
            if (projectTecnos == null)
            {
                return NotFound();
            }

            context.ProjectTecnos.Remove(projectTecnos);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProjectTecnosExists(int id)
        {
            return context.ProjectTecnos.Any(e => e.ProjectId == id);
        }
    }
}

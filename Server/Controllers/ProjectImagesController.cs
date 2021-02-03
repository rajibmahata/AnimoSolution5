using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared;
using Model.Shared.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectImagesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "ProjectImages";
        public ProjectImagesController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) { this.context = context; this.almacenadorArchivos = almacenadorArchivos; }

 
        [HttpGet] 
        public async Task<ActionResult<List<ProjectImages>>> Get()
        {
            return await context.ProjectImages.ToListAsync();
        }


        [HttpGet("{ProjectId}")]
        public async Task<ActionResult<ViewProjectImagesDTO>> Get(int ProjectId) 
        {
            var project = await context.Projects.Where(x => x.ProjectId == ProjectId).FirstOrDefaultAsync();
            if (project == null) { return NotFound(); }

            List<ProjectImages> fullImages = new List<ProjectImages>();
            try
            {
              fullImages = await context.ProjectImages.Where(x => x.ProjectId == ProjectId).Include(x => x.Image).ToListAsync();
            }
            catch (Exception e)
            {
                var _e = e.Message;
            }        

            var model = new ViewProjectImagesDTO();
            model.Project = project;

            if(fullImages.Count < 1)
            {
                model.ProjectImages = null;
            }
            else
            {
                model.ProjectImages = fullImages.ToList();
            }    
            return model;
        }





        [HttpPut("{ProjectId}")]
        public async Task<IActionResult> PutProjectImages(int ProjectId, ProjectImages projectImages) 
        {
            if (ProjectId != projectImages.ProjectId)
            {
                return BadRequest();
            }

            context.Entry(projectImages).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(ProjectId))
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
        public async Task<ActionResult<ProjectImages>> Post(ProjectImages projectImages) 
        {
            context.ProjectImages.Add(projectImages);


            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Exists(projectImages.ProjectId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return Ok(projectImages);
        }


        [HttpDelete("{ProjectId}")]
        public async Task<IActionResult> Delete(int ProjectId) 
        {
            // all ProjectID ref.
            List<ProjectImages> projectImages = await context.ProjectImages.Where(x => x.ProjectId == ProjectId).ToListAsync();
            if (projectImages == null)
            {return NotFound();}

            foreach (var item in projectImages)
            {
                context.ProjectImages.Remove(item);
            }            
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool Exists(int id)
        {
            return context.ProjectImages.Any(e => e.ProjectId == id);
        }
    }
}

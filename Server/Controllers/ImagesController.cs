using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "Project-Images";
        public ImagesController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        { this.context = context; this.almacenadorArchivos = almacenadorArchivos; }

     


        [HttpGet]
        public async Task<ActionResult<List<Images>>> GetImages()
        {
            return await context.Images.ToListAsync();
        }

   
        [HttpGet("{ImageId}")]
        public async Task<ActionResult<Images>> Get(int ImageId) 
        {
            var images = await context.Images.FindAsync(ImageId);

            if (images == null)
            {
                return NotFound();
            }

            return images;
        }


        [HttpPut("{ImageId}")]
        public async Task<IActionResult> PutImages(int ImageId, Images images)
        {
            if (ImageId != images.ImageId)
            {
                return BadRequest();
            }

            context.Entry(images).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Exists(ImageId))
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
        public async Task<ActionResult<int>> Post(Images image)
        {
            if (!string.IsNullOrEmpty(image.ImageFile))
            {
                var posterProject = Convert.FromBase64String(image.ImageFile);
                image.ImageFile = await almacenadorArchivos.GuardarArchivo(posterProject, "jpg", contenedor);

            }
            // sincrono
            context.Images.Add(image);
            context.SaveChanges();
            
            return image.ImageId;
        }


        [HttpDelete("{ImageId}")]
        public async Task<IActionResult> Delete(int ImageId) 
        {
            var images = await context.Images.FindAsync(ImageId);
            if (images == null)
            { return NotFound();}

            context.Images.Remove(images);
            await context.SaveChangesAsync();
            return NoContent();
        }



        private bool Exists(int ImageId)
        {
            return context.Images.Any(e => e.ImageId == ImageId);
        }
    }
}

using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Http;
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
    public class SocialsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "SocialLogos";

        public SocialsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }


        [HttpGet]
        public async Task<ActionResult<List<Social>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.Socials.OrderBy(x => x.Name).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }


        [HttpGet("{SocialId}")]
        public async Task<ActionResult<Social>> Get(int SocialId)
        {
            var socials = await context.Socials.FindAsync(SocialId);

            if (socials == null)
            {
                return NotFound();
            }
            return socials;
        }


        [HttpPut]
        public async Task<ActionResult> Put(Social socials)
        {
            var socialDB = await context.Socials.FirstOrDefaultAsync(x => x.SocialId == socials.SocialId);
            if (socialDB == null) { return NotFound(); }

            socialDB.SocialId = socials.SocialId;
            socialDB.Name = socials.Name;
            socialDB.TargetUrl = socials.TargetUrl;
            socialDB.isActive = socials.isActive;

            if (!string.IsNullOrWhiteSpace(socials.SocialIconUrl))
            {
                var posterImagen = Convert.FromBase64String(socials.SocialIconUrl);
                socialDB.SocialIconUrl = await almacenadorArchivos.EditarArchivo(posterImagen, "jpg", contenedor, socialDB.SocialIconUrl);
            }
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var x = ex.Message;
            }
            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(Social socials)
        {

            if (!string.IsNullOrEmpty(socials.SocialIconUrl))
            {
                var myLogo = Convert.FromBase64String(socials.SocialIconUrl);
                socials.SocialIconUrl = await almacenadorArchivos.GuardarArchivo(myLogo, "jpg", contenedor);
            }
            context.Socials.Add(socials);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();

            }
            return socials.SocialId;
        }


        [HttpDelete("{SocialId}")]
        public async Task<IActionResult> Delete(int SocialId)
        {
            var socials = await context.Socials.FindAsync(SocialId);
            if (socials == null)
            {
                return NotFound();
            }

            context.Socials.Remove(socials);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool SocialsExists(int SocialId)
        {
            return context.Socials.Any(e => e.SocialId == SocialId);
        }

    }
}

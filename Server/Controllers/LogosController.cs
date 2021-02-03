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
    public class LogosController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "AnimoLogos";

        public LogosController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }


        [HttpGet]
        public async Task<ActionResult<List<Logos>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.Logos.OrderBy(x => x.LogoName).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }


        [HttpGet("{LogoId}")]
        public async Task<ActionResult<Logos>> Get(int LogoId)
        {
            var logos = await context.Logos.FindAsync(LogoId);

            if (logos == null)
            {
                return NotFound();
            }
            return logos;
        }


        [HttpPut]
        public async Task<ActionResult> Put(Logos logos) 
        {
            var logoDB = await context.Logos.FirstOrDefaultAsync(x => x.LogoId == logos.LogoId); 
            if (logoDB == null) { return NotFound(); }


            logoDB.LogoId = logos.LogoId;
            logoDB.LogoName = logos.LogoName;
            logoDB.isDefaultActive = logos.isDefaultActive;


            if (!string.IsNullOrWhiteSpace(logos.LogoFile))
            {
                var logoImagen = Convert.FromBase64String(logos.LogoFile); 
                logoDB.LogoFile = await almacenadorArchivos.EditarArchivo(logoImagen, "jpg", contenedor, logoDB.LogoFile);
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
        public async Task<ActionResult<int>> Post(Logos logos) 
        {

            if (!string.IsNullOrEmpty(logos.LogoFile))
            {
                var myLogo = Convert.FromBase64String(logos.LogoFile);
                logos.LogoFile = await almacenadorArchivos.GuardarArchivo(myLogo, "jpg", contenedor); 
            }
            context.Logos.Add(logos);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();

            }
            return logos.LogoId;
        }


        [HttpDelete("{LogoId}")]
        public async Task<IActionResult> Delete(int LogoId)
        {
            var logos = await context.Logos.FindAsync(LogoId);
            if (logos == null)
            {
                return NotFound();
            }

            context.Logos.Remove(logos);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool LogosExists(int LogoId) 
        {
            return context.Logos.Any(e => e.LogoId == LogoId);
        }
    }

}


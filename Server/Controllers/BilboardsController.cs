using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared.Entities;
using AnimoWeb.Server.Helpers;
using Model.Shared.DTOs;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BilboardsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "AnimoBilboard";

        public BilboardsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }



        [HttpGet]
        public async Task<ActionResult<List<Bilboard>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.Bilboards.OrderBy(x => x.BilboardName).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }



        [HttpGet("{BilboardId}")]
        public async Task<ActionResult<Bilboard>> Get(int BilboardId)
        {
            var bilboard = await context.Bilboards.FindAsync(BilboardId);

            if (bilboard == null)
            {
                return NotFound();
            }
            return bilboard;
        }
               

        [HttpPut]
        public async Task<ActionResult> Put(Bilboard bilboard)
        {
            var bilboardDB = await context.Bilboards.FirstOrDefaultAsync(x => x.BilboardId == bilboard.BilboardId);
            if (bilboardDB == null) { return NotFound(); }

            bilboardDB.BilboardId = bilboard.BilboardId;
            bilboardDB.BilboardName = bilboard.BilboardName;
            bilboardDB.isDefaultActive = bilboard.isDefaultActive;

            if (!string.IsNullOrWhiteSpace(bilboard.BilboardFile))
            {
                var BilboardImagen = Convert.FromBase64String(bilboard.BilboardFile);
                bilboardDB.BilboardFile = await almacenadorArchivos.EditarArchivo(BilboardImagen, "jpg", contenedor, bilboardDB.BilboardFile);
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
        public async Task<ActionResult<int>> Post(Bilboard bilboards)
        {

            if (!string.IsNullOrEmpty(bilboards.BilboardFile))
            {
                var myBil = Convert.FromBase64String(bilboards.BilboardFile);
                bilboards.BilboardFile = await almacenadorArchivos.GuardarArchivo(myBil, "jpg", contenedor);
            }
            context.Bilboards.Add(bilboards);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();

            }
            return bilboards.BilboardId;
        }



        [HttpDelete("{BilboardId}")]
        public async Task<IActionResult> Delete(int BilboardId)
        {
            var bil = await context.Bilboards.FindAsync(BilboardId);
            if (bil == null)
            {
                return NotFound();
            }

            context.Bilboards.Remove(bil);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool BilboardExists(int id)
        {
            return context.Bilboards.Any(e => e.BilboardId == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AnimoWeb.Server;
using Model.Shared;
using Model.Shared.DTOs;
using AnimoWeb.Server.Helpers;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FirmasController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "FirmasLogos";

        public FirmasController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        
        [HttpGet]
        public async Task<ActionResult<List<Firmas>>> Get([FromQuery] Paginacion paginacion) 
        {
            var queryable = context.Firmas.OrderBy(x => x.Name).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }

       
        [HttpGet("{FirmaId}")]
        public async Task<ActionResult<Firmas>> Get(int FirmaId) 
        {
            var firmas = await context.Firmas.FindAsync(FirmaId);

            if (firmas == null)
            {
                return NotFound();
            }

            return firmas;
        }

    
        [HttpPut]
        public async Task<ActionResult> Put(Firmas firmas) 
        {
            var firmaDB = await context.Firmas.FirstOrDefaultAsync(x => x.FirmaId == firmas.FirmaId);
            if (firmaDB == null) { return NotFound(); }


            firmaDB.FirmaId = firmas.FirmaId;
            firmaDB.Address = firmas.Address;
            firmaDB.ContactEmail = firmas.ContactEmail;
            firmaDB.ContactPerson = firmas.ContactPerson;
            firmaDB.LandeId = firmas.LandeId;
            firmaDB.Name = firmas.Name;
            firmaDB.Phone = firmas.Phone;
            firmaDB.Town = firmas.Town;
            firmaDB.Zip = firmas.Zip;            
                        
            if (!string.IsNullOrWhiteSpace(firmas.Logo))
            {
                var posterImagen = Convert.FromBase64String(firmas.Logo);
                firmaDB.Logo = await almacenadorArchivos.EditarArchivo(posterImagen, "jpg", contenedor, firmaDB.Logo);
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
        public async Task<ActionResult<int>> Post(Firmas firmas)
        {

            if (!string.IsNullOrEmpty(firmas.Logo))
            {
                var logoFirma = Convert.FromBase64String(firmas.Logo); 
                firmas.Logo = await almacenadorArchivos.GuardarArchivo(logoFirma, "jpg", contenedor);
            }
            context.Firmas.Add(firmas);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString(); 

            }     
            return firmas.FirmaId;
        }

   
        [HttpDelete("{FirmaId}")]
        public async Task<IActionResult> Delete(int FirmaId)
        {
            var firmas = await context.Firmas.FindAsync(FirmaId);
            if (firmas == null)
            {
                return NotFound();
            }

            context.Firmas.Remove(firmas);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool FirmasExists(int FirmaId)
        {
            return context.Firmas.Any(e => e.FirmaId == FirmaId);
        }
    }
}

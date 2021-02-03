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
using Model.Shared.DTOs;

namespace AnimoWeb.Server.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "NewsPosters";

        public NewsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }

        [HttpGet]
        public async Task<ActionResult<List<News>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.News.Include(x => x.NewsGraphs).ThenInclude(x => x.Graph).OrderBy(x => x.Doc).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<News>> Get(int id)
        {
            var news = await context.News.FindAsync(id);

            if (news == null)
            {
                return NotFound();
            }

            return news;
        }

   
        [HttpPut]
        public async Task<ActionResult> Put(News news)
        {
            var newsDB = await context.News.FirstOrDefaultAsync(x => x.NewsId == news.NewsId);
            if (newsDB == null) { return NotFound(); }

            newsDB.NewsId = news.NewsId;
            newsDB.Body = news.Body;
            newsDB.Clicks = news.Clicks;
            newsDB.Dlu = news.Dlu;
            newsDB.Doc = news.Doc;
            newsDB.isActive = news.isActive;
            newsDB.LinkUrl = news.LinkUrl;
            newsDB.Tags = news.Tags;
            newsDB.Title = news.Title;
            newsDB.UserId = news.UserId;
            newsDB.VideoUrl = news.VideoUrl;           

            if (!string.IsNullOrWhiteSpace(news.PosterImage))
            {
                var posterImagen = Convert.FromBase64String(news.PosterImage);
                newsDB.PosterImage = await almacenadorArchivos.EditarArchivo(posterImagen, "jpg", contenedor, newsDB.PosterImage);
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
        public async Task<ActionResult<int>> Post(News news)
        {
            if (!string.IsNullOrEmpty(news.PosterImage))
            {
                var imagen = Convert.FromBase64String(news.PosterImage);
                news.PosterImage = await almacenadorArchivos.GuardarArchivo(imagen, "jpg", contenedor);
            }
            context.News.Add(news);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();

            }
            return news.NewsId;
        }




        [HttpDelete("{NewsId}")]
        public async Task<IActionResult> Delete(int NewsId)
        {
            var news = await context.News.FindAsync(NewsId);
            if (news == null)
            {
                return NotFound();
            }

            context.News.Remove(news);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool NewsExists(int id)
        {
            return context.News.Any(e => e.NewsId == id);
        }
    }
}

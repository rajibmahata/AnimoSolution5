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
    public class NewsGraphsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
    
        public NewsGraphsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        { this.context = context; this.almacenadorArchivos = almacenadorArchivos; }

      
        [HttpGet]
        public async Task<ActionResult<List<NewsGraphs>>> Get() 
        {
            var newsGraphs = new List<NewsGraphs>();

            try
            {               
               //newsGraphs = await context.NewsGraphs.Include(x => x.Graph).Include(x => x.Graph.GraphName).Include(x => x.).ToListAsync();
                newsGraphs = await context.NewsGraphs.ToListAsync();
            }
            catch (Exception ex)
            {
               var e = ex.Message;
            }
        

            var algo = "asd;";
            Console.WriteLine(algo);
            return newsGraphs; 
        }

     
        [HttpGet("{NewsId}")]        
        public async Task<ActionResult<ViewNewsImagesDTO>> Get(int NewsId) 
        {
            var news = await context.News.Where(x => x.NewsId == NewsId).FirstOrDefaultAsync(); 
            if (news == null) { return NotFound(); }

            List<NewsGraphs> fullImages = new List<NewsGraphs>();
            try
            {
                fullImages = await context.NewsGraphs.Where(x => x.NewsId == NewsId).Include(x => x.Graph).ToListAsync();
            }
            catch (Exception e)
            {
                var _e = e.Message;
            }

            var model = new ViewNewsImagesDTO();
            model.News = news;

            if (fullImages.Count < 1)
            {
                model.NewsGraphs = null;
            }
            else
            {
                model.NewsGraphs = fullImages.ToList();
            }
            return model;
        }


        [HttpPut]
        public async Task<IActionResult> Put(NewsGraphs newsGraphs)
        {
            var NewGraphId = newsGraphs.Id; 
            if (NewGraphId != newsGraphs.NewsId)
            {
                return BadRequest();
            }

            context.Entry(newsGraphs).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NewsGraphsExists(NewGraphId))
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
        public async Task<ActionResult<int>> Post(NewsGraphs newsGraphs) 
        {
            context.NewsGraphs.Add(newsGraphs);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (NewsGraphsExists(newsGraphs.NewsId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return newsGraphs.NewsId;
        }

 
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var newsGraphs = await context.NewsGraphs.FindAsync(id);
            if (newsGraphs == null)
            {
                return NotFound();
            }

            context.NewsGraphs.Remove(newsGraphs);
            await context.SaveChangesAsync();

            return NoContent();
        }

        private bool NewsGraphsExists(int id)
        {
            return context.NewsGraphs.Any(e => e.NewsId == id);
        }
    }
}

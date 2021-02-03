using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared.DTOs;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DTOHomeProjectController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public DTOHomeProjectController(ApplicationDbContext context) { this.context = context; }


        [HttpGet]
        public async Task<ActionResult<ViewHomeProjectsDTO>> Get()
        {
            var limite = 6;
            var allProjects = await context.Projects.ToListAsync();
            var projectsInAustria = await context.Projects.Where(x => x.isRestAustria).Take(limite).OrderByDescending(x => x.Doc).ToListAsync();
            var projectsInVorarlberg = await context.Projects.Where(x => x.isVorarlberg).Take(limite).OrderByDescending(x => x.Doc).ToListAsync();
            var projectsInternational = await context.Projects.Where(x => x.isInternational).Take(limite).OrderByDescending(x => x.Doc).ToListAsync();


            ViewHomeProjectsDTO viewHomeProjectsDTO = new ViewHomeProjectsDTO()
            {
                AllProjects = allProjects,
                ProjectsInRestAustria = projectsInAustria,
                ProjectsInternational = projectsInternational,
                ProjectsInVorarlberg = projectsInVorarlberg,

            };
            var model = viewHomeProjectsDTO;
            return model;
        }


    }
}

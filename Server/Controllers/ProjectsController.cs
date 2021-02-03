using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Authorization;
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
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "Projects";

        public ProjectsController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos ) {   
            this.context = context; 
            this.almacenadorArchivos = almacenadorArchivos;
          
        }

        [AllowAnonymous]
        [HttpGet("filter")]
        public async Task<ActionResult<List<Projects>>> Get([FromQuery] ParametrosBusquedaProjectos parametrosBusqueda)
        {
            var projectsQueryable = context.Projects.Where(x => x.isActive == true).AsQueryable(); 

            if (!string.IsNullOrWhiteSpace(parametrosBusqueda.Name)) 
            {
                projectsQueryable = projectsQueryable.Where(x => x.Name.ToLower().Contains(parametrosBusqueda.Name.ToLower())); 
            }

            if (parametrosBusqueda.isvorarlberg)
            {
                projectsQueryable = projectsQueryable.Where(x => x.isVorarlberg);
            }

            if (parametrosBusqueda.isrestaustria)
            {
                projectsQueryable = projectsQueryable.Where(x => x.isRestAustria);
            }

            if (parametrosBusqueda.isinternational)
            {
                projectsQueryable = projectsQueryable.Where(x => x.isInternational);
            }

            if (parametrosBusqueda.TecnoId != 0)
            {
                projectsQueryable = projectsQueryable
                    .Where(x => x.ProjectTecnos.Select(y => y.TecnoId)
                    .Contains(parametrosBusqueda.TecnoId));
            }


            await HttpContext.InsertarParametrosPaginacionEnRespuesta(projectsQueryable,
                parametrosBusqueda.CantidadRegistros);

            var projects = await projectsQueryable.Paginar(parametrosBusqueda.Paginacion).ToListAsync(); 

            return projects;
        }



        public class ParametrosBusquedaProjectos 
        {
            public int Pagina { get; set; } = 1;
            public int CantidadRegistros { get; set; } = 10;
            public Paginacion Paginacion
            {
                get { return new Paginacion() { Pagina = Pagina, CantidadRegistros = CantidadRegistros }; }
            }
            public string Name { get; set; }   
            public int TecnoId { get; set; }
            public bool isvorarlberg { get; set; } 
            public bool isrestaustria { get; set; } 
            public bool isinternational { get; set; } 
        } 


        [HttpGet]
        public async Task<ActionResult<List<Projects>>> Get([FromQuery] Paginacion paginacion)
        {
            var queryable = context.Projects.Where(x => x.isActive == true).OrderBy(x => x.Doc).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }



        [HttpGet("{ProjectId}")]
        public async Task<ActionResult<ViewProjectDTO>> Get(int ProjectId)
        {
            var project = await context.Projects.Where(x => x.ProjectId == ProjectId)
                .Include(x => x.ProjectTecnos).ThenInclude(x => x.Tecno)
                .Include(x => x.ProjectImages).ThenInclude(x => x.Image)
                .FirstOrDefaultAsync();

            if (project == null) { return NotFound(); }

            project.ProjectTecnos = project.ProjectTecnos.OrderBy(x => x.TecnoId).ToList();
            project.ProjectImages = project.ProjectImages.ToList();

            var model = new ViewProjectDTO();
            model.Project = project;
            model.Tecnos = project.ProjectTecnos.Select(x => x.Tecno).ToList();
            model.Images = project.ProjectImages.Select(x => x.Image).ToList();

            return model;
        }


        [HttpGet("update/{ProjectId}")]
        public async Task <ActionResult<ViewUpdateProjectDTO>> PutGet (int ProjectId)
        {
            var projectActionResult = await Get(ProjectId);
            if(projectActionResult.Result is NotFoundResult) { return NotFound(); }

            var projectDTO = projectActionResult.Value;  
            var tecnosSeleccionadosIds = projectDTO.Tecnos.Select(x => x.TecnoId).ToList();
            var tecnosNoSeleccionados = await context.Tecnos.Where(x => !tecnosSeleccionadosIds.Contains(x.TecnoId)).ToListAsync();

            var model = new ViewUpdateProjectDTO();
            model.Project = projectDTO.Project;
            model.TecnosUnSelected = tecnosNoSeleccionados;
            model.TecnosSelected = projectDTO.Tecnos;
            model.ProjectImages = projectDTO.Images;

            return model;
        }


        [HttpPost]
        public async Task<ActionResult<int>> Post(Projects project) 
        {
            if(!string.IsNullOrEmpty(project.Poster))
            {
                var posterProject = Convert.FromBase64String(project.Poster);
                project.Poster = await almacenadorArchivos.GuardarArchivo(posterProject, "jpg", contenedor);

            }
            context.Add(project);
            await context.SaveChangesAsync();
            return project.ProjectId;
        }


        [HttpPut]
        public async Task<ActionResult> Put(Projects project)  
        {
            var projectDB = await context.Projects.FirstOrDefaultAsync(x => x.ProjectId == project.ProjectId);
            if (projectDB == null) { return NotFound(); }

         
            projectDB.ProjectId = project.ProjectId;
            projectDB.Description = project.Description;
            projectDB.Dlu = project.Dlu;
            projectDB.Doc = project.Doc;
            projectDB.isActive = true;
            projectDB.isInternational = project.isInternational;
            projectDB.isRestAustria = project.isRestAustria;
            projectDB.isVorarlberg = project.isVorarlberg;
            projectDB.KundeName = project.KundeName;
            projectDB.Name = project.Name;

            //projectDB.ProjectImages = project.ProjectImages;
            await context.Database.ExecuteSqlInterpolatedAsync($"delete from ProjectTecnos WHERE ProjectId = {project.ProjectId};");

            foreach (var item in project.ProjectTecnos)
            {
                InsertTecnologias(project.ProjectId, item.TecnoId);
            }


            projectDB.VideoPreview = project.VideoPreview;
            projectDB.VideoUrl = project.VideoUrl;            

            if (!string.IsNullOrWhiteSpace(project.Poster))
            {
                var posterImagen = Convert.FromBase64String(project.Poster);
                projectDB.Poster = await almacenadorArchivos.EditarArchivo(posterImagen, "jpg", contenedor, projectDB.Poster); 
            }

            //await context.Database.ExecuteSqlInterpolatedAsync($"delete from ProjectTecnos WHERE ProjectId = {project.ProjectId};");
            try
            {
                context.Attach(projectDB).State = EntityState.Modified;
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                var x = ex.Message;
            }               
            return NoContent();
        }


        void InsertTecnologias (int ProjectId, int TecnoId)
        {
            ProjectTecnos pt = new ProjectTecnos();
            pt.ProjectId = ProjectId;
            pt.TecnoId = TecnoId;

            context.Add(pt);
            context.SaveChanges();            
        }



        [HttpDelete("{ProjectId}")] 
        public async Task<IActionResult> Delete(int ProjectId)
        {
            var project = await context.Projects.FindAsync(ProjectId);
            if (project == null)
            {
                return NotFound();
            }
            try
            {
                context.Projects.Remove(project);
                await context.Database.ExecuteSqlInterpolatedAsync($"delete from ProjectTecnos WHERE ProjectId = {project.ProjectId};");
                await context.Database.ExecuteSqlInterpolatedAsync($"delete from ProjectImages WHERE ProjectId = {project.ProjectId};");                
            }
            catch (Exception ex)
            {

                var e = ex.Message;
            }

            await context.SaveChangesAsync();

            return Ok();


        }


    }
}

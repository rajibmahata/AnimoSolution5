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
    public class UsersController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "UserPosters";

        public UsersController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos) 
        {
           this.context = context;
           this.almacenadorArchivos = almacenadorArchivos;
        }



        [HttpGet]
        public async Task<ActionResult<List<Users>>> Get([FromQuery] Paginacion paginacion) 
        {
            var queryable = context.Users.OrderBy(x => x.OrderPosition).AsQueryable();
            await HttpContext.InsertarParametrosPaginacionEnRespuesta(queryable, paginacion.CantidadRegistros);
            return await queryable.Paginar(paginacion).ToListAsync();
        }
                
        
        [HttpGet("{UserId}")]
        public async Task<ActionResult<Users>> Get(int UserId) 
        {
            var users = await context.Users.FindAsync(UserId);

            if (users == null)
            {
                return NotFound();
            }

            return users;
        }


        // Lucas new REGISTER !!!!!"!
        [HttpPost]
        public async Task<ActionResult<int>> Post(VMUserRegister VMusers)
        {
            Users user = new Users();
            string password = VMusers.Password;

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            user.UserId = VMusers.UserId;
            user.Dob = VMusers.Dob;
            user.Doc = VMusers.Doc;
            user.Dol = VMusers.Dol;
            user.Email = VMusers.Email;
            user.FirmaId = VMusers.FirmaId;
            user.FullName = VMusers.FullName;
            user.isBanned = VMusers.isBanned;
            user.isDeleted = VMusers.isDeleted;
            user.JobPosition = VMusers.JobPosition;
            user.JobPositionDescription = VMusers.JobPositionDesc;
            user.Phone = VMusers.Phone;
            user.LandeId = VMusers.LandeId;
            //user.Password = VMusers.Password;

            user.RoleId = VMusers.RoleId;
            user.Username = VMusers.Username;
            user.OrderPosition = VMusers.OrderPosition;

            if (!string.IsNullOrEmpty(VMusers.UserPoster))
            {
                var userPicture = Convert.FromBase64String(VMusers.UserPoster);
                user.UserPoster = await almacenadorArchivos.GuardarArchivo(userPicture, "jpg", contenedor);
            }
            context.Users.Add(user);
            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();
            }
            return user.UserId;
        }


        // UPDATING THE USER
        [HttpPut]
        public async Task<IActionResult> Put(Users VMusers)  
        {  
            var user = context.Users.Where(x => x.UserId == VMusers.UserId).FirstOrDefault();    
            string password = VMusers.Password;

            CreatePasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.UserId = VMusers.UserId;
            user.Dob = VMusers.Dob;
            user.Doc = VMusers.Doc;
            user.Dol = VMusers.Dol;
            user.Email = VMusers.Email;
            user.FirmaId = VMusers.FirmaId;
            user.FullName = VMusers.FullName;
            user.isBanned = VMusers.isBanned;
            user.isDeleted = VMusers.isDeleted;
            user.JobPosition = VMusers.JobPosition;
            user.JobPositionDescription = VMusers.JobPositionDescription;
            user.LandeId = VMusers.LandeId;
            user.Phone = VMusers.Phone;
            user.OrderPosition = VMusers.OrderPosition;
            //user.Password = VMusers.Password;

            user.RoleId = VMusers.RoleId;
            user.Username = VMusers.Username;

            if (!string.IsNullOrEmpty(VMusers.UserPoster))
            {
                var userPicture = Convert.FromBase64String(VMusers.UserPoster);
                user.UserPoster = await almacenadorArchivos.GuardarArchivo(userPicture, "jpg", contenedor);
            }

            //context.Users.Add(user);
            context.Entry(user).State = EntityState.Modified;

            try
            {
                await context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                var _error = e.Message.ToString();
            }
            return Ok();
        }

            

        [HttpDelete("{UserId}")]
        public async Task<ActionResult> Delete(int UserId)
        {

            var users = await context.Users.FindAsync(UserId);

            if(users.Username.ToLower().Contains("lucas") || users.FullName.ToLower().Contains("lucas"))
            {
                return NoContent();
            }

            if (users == null)
            {
                return NotFound();
            }

            context.Users.Remove(users);
            await context.SaveChangesAsync();

            return NoContent();
        }

 
        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                for (int i = 0; i < computedHash.Length; i++)
                {
                    if (computedHash[i] != passwordHash[i])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}

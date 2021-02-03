using AnimoWeb.Server.Helpers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserUpdateController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        private readonly IAlmacenadorArchivos almacenadorArchivos;
        private readonly string contenedor = "UserPosters";

        public UserUpdateController(ApplicationDbContext context, IAlmacenadorArchivos almacenadorArchivos)
        {
            this.context = context;
            this.almacenadorArchivos = almacenadorArchivos;
        }


        [HttpPut]
        public async Task<ActionResult<int>> Put(VMUserRegister VMusers)    
        {
            Console.WriteLine("Should be entered into the CONTROLLER");
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
            user.JobPositionDescription = VMusers.JobPositionDesc;
            user.LandeId = VMusers.LandeId;
            user.Password = VMusers.Password;

            user.RoleId = VMusers.RoleId;
            user.Username = VMusers.Username;

            if (!string.IsNullOrEmpty(VMusers.UserPoster))
            {
                var userPicture = Convert.FromBase64String(VMusers.UserPoster);
                user.UserPoster = await almacenadorArchivos.GuardarArchivo(userPicture, "jpg", contenedor);
            }
            context.Users.Add(user);
            //context.Entry(user).State = EntityState.Modified;
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

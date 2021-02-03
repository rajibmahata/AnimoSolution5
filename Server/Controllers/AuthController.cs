using AnimoWeb.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Shared;
using System.Threading.Tasks;

namespace AnimoWeb.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private readonly ApplicationDbContext context;
        private readonly IAuthRepository authRepo; 


        public AuthController(ApplicationDbContext context, IAuthRepository authRepo) 
        {
            this.context = context;
            this.authRepo = authRepo;
        }


        //Lucas Login
        [HttpPost("login")]
        public async Task<ActionResult> Put(UserLogin userLogin) 
        {    
            var response = await authRepo.Login(userLogin.Email, userLogin.Password);
            if (!response.Success)
            {
                return BadRequest(response);
            }
       
            else
            {
                return Ok(response);       
            }
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

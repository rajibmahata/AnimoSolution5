using Model.Shared;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
 
namespace AnimoWeb.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _http;
  
        public AuthService(HttpClient http){
            _http = http;
       
        }

        public async Task<ServiceResponse<string>> Login(UserLogin req)
        {
            var result = await _http.PostAsJsonAsync("api/Auth/login", req);
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        
    }
}

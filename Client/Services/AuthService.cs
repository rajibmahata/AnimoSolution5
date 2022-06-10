using AnimoWeb.Client.Auth;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using Model.Shared;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
 
namespace AnimoWeb.Client.Services
{
    public class AuthService : IAuthService
    {
        private readonly HttpClient _httpClient;
        private readonly AuthenticationStateProvider _authenticationStateProvider;
        private readonly ILocalStorageService _localStorage;

        public AuthService(HttpClient httpClient,
                           AuthenticationStateProvider authenticationStateProvider,
                           ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _authenticationStateProvider = authenticationStateProvider;
            _localStorage = localStorage;
        }

        public async Task<ServiceResponse<string>> Login(UserLogin req)
        {
            var result = await _httpClient.PostAsJsonAsync("api/Auth/login", req);
            var response= await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
            if (response.Success)
            {
                await _localStorage.SetItemAsync("authToken", response.Data);
                ((CustomAuthStateProvider)_authenticationStateProvider).MarkUserAsAuthenticated(response.Data);
                _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("bearer", response.Data);

                return response;
            }

            return response;
            

           // return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
        }

        
    }
}

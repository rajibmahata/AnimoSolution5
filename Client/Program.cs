using Blazored.LocalStorage;
using Blazored.Toast;
using AnimoWeb.Client.Services;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AnimoWeb.Client.Repositories;
using AnimoWeb.Client.Helpers;
using AnimoWeb.Client.Auth;
using Blazored.SessionStorage;

namespace AnimoWeb.Client
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddSingleton(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            
            builder.Services.AddScoped<IAuthService, AuthService>();
           
            
            builder.Services.AddBlazoredLocalStorage();
            builder.Services.AddBlazoredSessionStorage();

            builder.Services.AddOptions();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthStateProvider>();               

            ConfigureServices(builder.Services);

            await builder.Build().RunAsync();
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<IMostrarMensajes, MostrarMensajes>();
            services.AddAuthorizationCore();         
        
        }

    }
}

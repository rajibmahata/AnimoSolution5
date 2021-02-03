using Model.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AnimoWeb.Client.Repositories
{
    public interface IRepository 
    {
        Task<HttpResponseWrapper<object>> Delete(string url);
        Task<HttpResponseWrapper<T>> Get<T>(string url);
        Task<HttpResponseWrapper<object>> Post<T>(string url, T enviar);
        Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Put<T>(string url, T enviar);
        Task<HttpResponseWrapper<object>> Login<T>(string url, T enviar); 
    }
}


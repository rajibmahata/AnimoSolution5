using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Client.Helpers
{
    public class MostrarMensajes : IMostrarMensajes
    {
        private readonly IJSRuntime jsRuntime; 
        public MostrarMensajes(IJSRuntime jsRuntime) 
        {
            this.jsRuntime = jsRuntime;
        }

        public async Task MostrarMensajeError(string mensaje)
        {
            await MostrarMensaje("error", "Error in operation");
        }

        public async Task MostrarMensajeExito(string mensaje) 
        {
            await MostrarMensaje("success", "It was succesfull");
        }

        private async ValueTask MostrarMensaje(string tipoMensaje, string titulo)
        {
         
            await jsRuntime.InvokeVoidAsync("Swal.fire", tipoMensaje, titulo);
        }



    }
}

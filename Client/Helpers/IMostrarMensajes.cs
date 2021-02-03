﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimoWeb.Client.Helpers
{
    public interface IMostrarMensajes
    {
        Task MostrarMensajeError(string mensaje);
        Task MostrarMensajeExito(string mensaje); 
    }
}

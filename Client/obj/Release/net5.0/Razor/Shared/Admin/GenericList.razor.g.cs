#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7dd93745faa7f1e5f154a680d92f1564d7b95122"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Shared.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Model.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using AnimoWeb.Client.Shared.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Model.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "H:\Upwork\New folder\AnimoSolution5-0\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    public partial class GenericList<Titem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
 if (Listado == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
     if (Cargando == null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.LoadingAsset>(0);
            __builder.CloseComponent();
#nullable restore
#line 9 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
         Cargando

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
                 
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
     
}
else if (Listado.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
     if (NoHayRegistros == null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "No records found...");
#nullable restore
#line 19 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
                                        
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 23 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
         NoHayRegistros

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
                       
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
     
}
else
{
    if (HayRegistros != null)
    {
        foreach (var elemento in Listado)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, 
#nullable restore
#line 32 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
             HayRegistros(elemento)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 32 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
                                   
        }
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
         HayRegistrosCompleto

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
                             
    }
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\GenericList.razor"
       
    [Parameter] public RenderFragment Cargando { get; set; }
    [Parameter] public RenderFragment NoHayRegistros { get; set; }
    [Parameter] public RenderFragment<Titem> HayRegistros { get; set; }
    [Parameter] public RenderFragment HayRegistrosCompleto { get; set; }
    [Parameter] public List<Titem> Listado { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

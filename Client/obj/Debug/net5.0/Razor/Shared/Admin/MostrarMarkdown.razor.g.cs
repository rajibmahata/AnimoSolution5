#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de834e85c98613435bc76e9ca641f335ab75d949"
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
#line 1 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Model.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using AnimoWeb.Client.Shared.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Model.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
using Markdig;

#line default
#line hidden
#nullable disable
    public partial class MostrarMarkdown : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
 if (string.IsNullOrEmpty(ContenidoHTML))
{
    if (PlantillaCarga != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
         PlantillaCarga

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
                       
    }
}
else
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, 
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
      (MarkupString)ContenidoHTML

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 12 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
                                  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Shared\Admin\MostrarMarkdown.razor"
       
    [Parameter] public string ContenidoMarkdown { get; set; }
    [Parameter] public RenderFragment PlantillaCarga { get; set; }
    private string ContenidoHTML;

    protected override void OnParametersSet()
    {
        if (ContenidoMarkdown != null)
        {
            ContenidoHTML = Markdown.ToHtml(ContenidoMarkdown);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Bilboards\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300f3a9aa1bf94d826ef21f755a33a1a9ecd6343"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Admin.Bilboards
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
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Bilboards\Create.razor"
using Model.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/bilboards/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5>Bilboard add</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">Add Bilboard here - Remember to Active / Deactive them as per your need</p></div></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "grid50r-- vtop");
            __builder.AddMarkupContent(5, "<h5>Options</h5>\r\n        <hr class=\"hr4inverted\">\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "hh-40 vtop");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.GoBack>(8);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "mt-25 grid100l--");
            __builder.OpenComponent<AnimoWeb.Client.Admin.Bilboards.BilboardForm>(12);
            __builder.AddAttribute(13, "bilboards", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.Shared.Entities.Bilboard>(
#nullable restore
#line 30 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Bilboards\Create.razor"
                                 bilboards

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 30 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Bilboards\Create.razor"
                                                           HandleCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Bilboards\Create.razor"
       

    private Bilboard bilboards = new Bilboard(); 

    
    private async Task HandleCreate()
    {

        var httpResponse = await repo.Post("api/bilboards", bilboards);
        if (httpResponse.Error)
        {            
            await mostrarMensajes.MostrarMensajeError(await httpResponse.GetBody());

        } else
        {
            nm.NavigateTo("/admin/bilboards");
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrarMensajes { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c479b7dae210b8c085aec473243e330acf5b87bc"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Admin.Firma
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
#line 3 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
using Model.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
           [Authorize(Roles="Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/firma/edit/{FirmaId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/firma/edit/{FirmaId:int}/{Name}")]
    public partial class Edit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5>Firma Edition</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">Edit your record here</p></div></div>\r\n\r\n    ");
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
#nullable restore
#line 28 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
 if (paises.Count < 1)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.LoadingAsset>(9);
            __builder.CloseComponent();
#nullable restore
#line 31 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
    }
else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Admin.Firma.FirmasForm>(10);
            __builder.AddAttribute(11, "firmas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.Shared.Firmas>(
#nullable restore
#line 34 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
                          firmas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 34 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
                                                 HandleEdit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(13, "paises", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Landes>>(
#nullable restore
#line 34 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
                                                                     paises

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 35 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Firma\Edit.razor"
       

    [Parameter] public int FirmaId { get; set; }
    [Parameter] public string Name { get; set; }
    private Firmas firmas = new Firmas();
    public List<Landes> paises = new List<Landes>();


    protected async override Task OnInitializedAsync()
    {
        await LoadCountries();

        var httpResponse = await repo.Get<Firmas>($"api/firmas/{FirmaId}");

        if (httpResponse.Error)
        {
            if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                nm.NavigateTo("admin");
            }
            else
            {
                await mostrar.MostrarMensajeError(await httpResponse.GetBody());
            }
        }
        else
        {
            firmas = httpResponse.Response;
        }

    }

    private async Task HandleEdit()
    {
        var httpResponse = await repo.Put("api/firmas", firmas);

        if (httpResponse.Error)
        {
            await mostrar.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            nm.NavigateTo("admin/firma");
        }
    }

    private async Task LoadCountries()
    {
        var httpResponse = await repo.Get<List<Landes>>("api/landes");
        paises = httpResponse.Response;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
    }
}
#pragma warning restore 1591

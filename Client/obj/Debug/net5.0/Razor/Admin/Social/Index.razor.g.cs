#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf97c2881f052117242bb81e70a252bc1f647d8c"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Admin.Social
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/social")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5>Social Icons for the Website</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">You can easily manage the Icons and Social links</p></div></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "grid50r-- vtop");
            __builder.AddMarkupContent(5, "<h5>Options</h5>\r\n        <hr class=\"hr4inverted\">\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "hh-40 vtop");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.GoBack>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<a href=\"admin/social/create\" class=\"btn btn-primary\">Create Record</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
 if (social == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.LoadingAsset>(11);
            __builder.CloseComponent();
#nullable restore
#line 28 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.AnimoWeb.Client.Admin.Social.Index.TypeInference.CreateGenericList_0(__builder, 12, 13, 
#nullable restore
#line 31 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                          social

#line default
#line hidden
#nullable disable
            , 14, (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "mr-50 ml-50");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "divTable greyGridTable");
                __builder2.AddMarkupContent(19, @"<div class=""divTableHeading ""><div class=""divTableRow ""><div class=""divTableHead grid20l--"">Icon</div>
                            <div class=""divTableHead grid10l"">Social Name</div>
                            <div class=""divTableHead grid20l--"">Target URL</div>
                            <div class=""divTableHead grid20l--"">is Active</div>

                            <div class=""divTableHead grid20c--"" style=""background-color:black;"">Actions</div></div></div>
                    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "divTableBody ");
#nullable restore
#line 47 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                         foreach (var item in social)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "divTableRow");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "divTableCell grid10l");
                __builder2.OpenElement(26, "img");
                __builder2.AddAttribute(27, "src", 
#nullable restore
#line 50 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                         item.SocialIconUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "class", "img128");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "divTableCell grid20l--");
                __builder2.AddContent(32, 
#nullable restore
#line 51 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                 item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "divTableCell grid20l--");
                __builder2.AddContent(36, 
#nullable restore
#line 52 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                 item.TargetUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                            ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "divTableCell grid20l--");
                __builder2.AddContent(40, 
#nullable restore
#line 53 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                 item.isActive

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n\r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "divTableCell grid20c--");
                __builder2.OpenElement(44, "a");
                __builder2.AddAttribute(45, "href", "admin/social/edit/" + (
#nullable restore
#line 56 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                            item.SocialId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(46, "class", "btn btn-success");
                __builder2.AddContent(47, "Edit");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                                ");
                __builder2.OpenElement(49, "button");
                __builder2.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                    () => DeleteGlobal(item.SocialId)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "class", "btn btn-danger");
                __builder2.AddContent(52, "Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 60 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n                    <div class=\"divTableFoot tableFootStyle\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.AddMarkupContent(54, "\r\n    <br>\r\n    <br>");
#nullable restore
#line 71 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
     if (social.Count >= 1)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.Paginacion>(55);
            __builder.AddAttribute(56, "PaginaActual", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                  paginaActual

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "PaginaSeleccionada", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Int32>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Int32>(this, 
#nullable restore
#line 73 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                    paginaSeleccionada

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(58, "PaginasTotales", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 73 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
                                                                                                        paginasTotales

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 74 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 74 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 80 "H:\Upwork\New folder\AnimoSolution5-0\Client\Admin\Social\Index.razor"
       

    public List<Social> social { get; set; } 
    private int paginaActual = 1;
    private int paginasTotales;


    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await Load(pagina);
    }


    protected async override Task OnInitializedAsync()
    {
        await Load();
    }


    private async Task Load(int pagina = 1)
    {
        var responseHttp = await repo.Get<List<Social>>($"api/socials?pagina={pagina}");

        if (!responseHttp.Error)
        {
            social = responseHttp.Response;
            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();
            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());
        }

    }

    private async Task DeleteGlobal(int SocialId)
    {
        var responseHttp = await repo.Delete($"api/socials/{SocialId}");  
        if (responseHttp.Error)
        {
            await mostrar.MostrarMensajeError(await responseHttp.GetBody());
        }
        else
        {
            await Load();
        }

    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
    }
}
namespace __Blazor.AnimoWeb.Client.Admin.Social.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::AnimoWeb.Client.Shared.Admin.GenericList<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistrosCompleto", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace AnimoWeb.Client.Pages
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectview/{ProjectId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/projectview/{ProjectId:int}/{Name}")]
    public partial class ProjectView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 192 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Pages\ProjectView.razor"
       

    [Parameter] public int ProjectId { get; set; }
    [Parameter] public string Name { get; set; }


    private Model.Shared.Projects thisProject { get; set; }
    private Tecnos Tecnos { get; set; }
    private ProjectImages projectImages { get; set; }
    private List<Images> images { get; set; }

    public ViewProjectDTO model = new ViewProjectDTO();
    private RenderFragment<Tecnos> enlanceTecno = (Tecnos) =>

#line default
#line hidden
#nullable disable
        (__builder2) => {
            __builder2.OpenElement(0, "div");
            __builder2.AddAttribute(1, "class", "colorLightGrey p12 badge badge-dark");
            __builder2.AddAttribute(2, "style", "text-align:left;");
            __builder2.AddContent(3, 
#nullable restore
#line 204 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Pages\ProjectView.razor"
                                                                                                                                         Tecnos.TecnoName

#line default
#line hidden
#nullable disable
            );
            __builder2.CloseElement();
        }
#nullable restore
#line 204 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Pages\ProjectView.razor"
                                                                                                                                                               ;


    public List<ProjectImages> newsImagesList = new List<ProjectImages>();
    public int cantidad = 0;


    protected async override Task OnInitializedAsync()
    {
    // Obtengo sus Imagenes
    var httpResponse = await repo.Get<ViewProjectImagesDTO>($"api/projectimages/{ProjectId}");
    if (httpResponse.Error)
    {
    await mostrar.MostrarMensajeError(await httpResponse.GetBody());
    }
    else
    {
    newsImagesList = httpResponse.Response.ProjectImages;
    thisProject = httpResponse.Response.Project;

    if (newsImagesList == null)
    {
    cantidad = 0;
    }
    else
    {
    newsImagesList = httpResponse.Response.ProjectImages;
    cantidad = newsImagesList.Count;
    }
    }

    var responseGraphicos = await repo.Get<List<Images>>("api/images");
    images = responseGraphicos.Response;

    var httpModelRequest = await repo.Get<ViewProjectDTO>($"api/projects/{ProjectId}");


    // Chequeo Tecnologias
    if (httpResponse.Error)
    {
    if (httpResponse.HttpResponseMessage.StatusCode == System.Net.HttpStatusCode.NotFound)
    {
    nm.NavigateTo("admin");
    }
    else
    {
    await mostrar.MostrarMensajeError("Another Error - Check SysAdmin");
    }
    }
    else
    {
    model = httpModelRequest.Response;
    }




    }


    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
    }
}
#pragma warning restore 1591

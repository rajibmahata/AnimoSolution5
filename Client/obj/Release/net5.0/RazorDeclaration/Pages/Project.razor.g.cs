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
    [Microsoft.AspNetCore.Components.RouteAttribute("/projects")]
    public partial class Project : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 230 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Pages\Project.razor"
        
    
    
    private List<Model.Shared.Projects> projects = new List<Model.Shared.Projects>();

    string Name = "";
    string tecnoSelected = "0";
    private bool isvorarlberg = false;
    private bool isrestaustria = false;
    private bool isinternational = false;
    private List<Tecnos> tecnos = new List<Tecnos>();

    Dictionary<string, string> queryStringsDict = new Dictionary<string, string>();

    private int paginaActual = 1;
    private int paginasTotales;



    protected override async Task OnInitializedAsync()
    {
        await ObtenerTecnos();

        var url = nm.Uri;

        var queries = nm.ObtenerQueryStrings(url);

        if (queries == null)
        {
            await RealizarBusqueda(string.Empty);
        }
        else
        {
            queryStringsDict = queries;
            LlenarCampos();
            var queryStrings = url.Split(new string[] { "?" }, StringSplitOptions.None)[1];
            await RealizarBusqueda(queryStrings);
        }
    }

    private void LlenarCampos()
    {
        if (queryStringsDict.ContainsKey("tecnoid"))
        {
            tecnoSelected = queryStringsDict["tecnoid"];
        }

        if (queryStringsDict.ContainsKey("Name"))
        {
            Name = queryStringsDict["Name"];
        }

        if (queryStringsDict.ContainsKey("isvorarlberg"))
        {
            bool.TryParse(queryStringsDict["isvorarlberg"], out isvorarlberg);
        }

        if (queryStringsDict.ContainsKey("isrestaustria"))
        {
            bool.TryParse(queryStringsDict["isrestaustria"], out isrestaustria);
        }

        if (queryStringsDict.ContainsKey("isinternational"))
        {
            bool.TryParse(queryStringsDict["isinternational"], out isinternational);
        }

        if (queryStringsDict.ContainsKey("pagina"))
        {
            int.TryParse(queryStringsDict["pagina"], out paginaActual);
        }
    }

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await LoadNewProjects();
    }

    private async Task ObtenerTecnos()
    {
        var httpResponse = await repo.Get<List<Tecnos>>("api/tecnos");
        tecnos = httpResponse.Response;
    }

    private async Task NameKeyPress(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await LoadNewProjects();
        }
    }

    private async Task LoadNewProjects()
    {
        var queryStrings = GenerarQueryStrings();
        nm.NavigateTo("/projects?" + queryStrings);
        await RealizarBusqueda(queryStrings);
    }

    private async Task RealizarBusqueda(string queryStrings)
    {
        var httpResponse = await repo.Get<List<Model.Shared.Projects>>("api/projects/filter?" + queryStrings);
        paginasTotales = int.Parse(httpResponse.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());
        projects = httpResponse.Response;
    }

    private string GenerarQueryStrings()
    {
        if (queryStringsDict == null) { queryStringsDict = new Dictionary<string, string>(); }
        queryStringsDict["tecnoid"] = tecnoSelected;
        queryStringsDict["Name"] = Name;
        queryStringsDict["isvorarlberg"] = isvorarlberg.ToString();
        queryStringsDict["isrestaustria"] = isrestaustria.ToString();
        queryStringsDict["isinternational"] = isinternational.ToString();
        queryStringsDict["pagina"] = paginaActual.ToString();

        var valoresPorDefecto = new List<string>() { "false", "", "0" };

        // generoid=7&titulo=spider ...

        return string.Join("&", queryStringsDict.Where(x => !valoresPorDefecto.Contains(x.Value.ToLower()))
            .Select(x => $"{x.Key}={System.Web.HttpUtility.UrlEncode(x.Value)}").ToArray());
    }

    private async Task LimpiarOnClick()
    {
        Name = "";
        tecnoSelected = "0";
        isvorarlberg = false;
        isrestaustria = false;
        isinternational = false;
        paginaActual = 1;
        await LoadNewProjects();

    }

    void ChangeStateVorarlberg()
    {
        isrestaustria = false;
        isinternational = false;
    }
    void changeStateRestAustria()
    {
        isvorarlberg = false;
        isinternational = false;
    }
    void changeStateInternational()
    {
        isvorarlberg = false;
        isrestaustria = false;
    } 

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
    }
}
#pragma warning restore 1591

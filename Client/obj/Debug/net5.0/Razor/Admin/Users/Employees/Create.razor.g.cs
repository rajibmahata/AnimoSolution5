#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec2b03cf45fef5ffed37f8a9bb80095b3033f0ad"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Admin.Users.Employees
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
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
using Model.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/users/employees/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5>User creation</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">Add Users</p></div></div>\r\n\r\n    ");
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
#nullable restore
#line 30 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
     if (paises.Count < 1)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.LoadingAsset>(12);
            __builder.CloseComponent();
#nullable restore
#line 33 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
    }
    else
    {
     

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<AnimoWeb.Client.Admin.Users.Employees.EmployeesForm>(13);
            __builder.AddAttribute(14, "userRegister", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.Shared.VMUserRegister>(
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
                                     userRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
                                                                  HandleCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "paises", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Landes>>(
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
                                                                                        paises

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "firmas", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Firmas>>(
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
                                                                                                        firmas

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "roles", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Roles>>(
#nullable restore
#line 37 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
                                                                                                                       roles

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 38 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Users\Employees\Create.razor"
       

    //private Users users = new Users();
    public List<Landes> paises = new List<Landes>();
    public List<Roles> roles = new List<Roles>();
    public List<Firmas> firmas = new List<Firmas>();

    private VMUserRegister userRegister = new VMUserRegister();


    protected async override Task OnInitializedAsync()
    {
        var ResponsePaises = await repo.Get<List<Landes>>("api/landes");
        paises = ResponsePaises.Response;

        var ResponseRoles = await repo.Get<List<Roles>>("api/roles");
        roles = ResponseRoles.Response;

        var ResponseFirmas = await repo.Get<List<Firmas>>("api/firmas");
        firmas = ResponseFirmas.Response;
    }


    private async Task HandleCreate()
    {

        var result = await repo.Post("api/users", userRegister);   
        if (result.Error)
        {
            var body = await result.GetBody();
            await mostrarMensajes.MostrarMensajeError(body);
        }
        else
        {
            nm.NavigateTo("/admin/users/employees");
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

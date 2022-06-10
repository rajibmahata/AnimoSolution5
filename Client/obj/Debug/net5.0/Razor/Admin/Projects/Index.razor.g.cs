#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1126de27d8a743f8453b86ab1c9a845ed544cc4"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Admin.Projects
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
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
           [Authorize(Roles = "Admin")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5>Projects</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">Projects to be shown in web site.</p></div></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "grid50r-- vtop");
            __builder.AddMarkupContent(5, "<h5>Options</h5>\r\n        <hr class=\"hr4inverted\">\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "hh-40 vtop");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.GoBack>(8);
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.AddMarkupContent(10, "<a href=\"admin/projects/create\" class=\"btn btn-primary\">Create Record</a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.OpenElement(12, "div");
            __Blazor.AnimoWeb.Client.Admin.Projects.Index.TypeInference.CreateGenericList_0(__builder, 13, 14, 
#nullable restore
#line 30 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                          projects

#line default
#line hidden
#nullable disable
            , 15, (__builder2) => {
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "mr-50 ml-50");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "divTable greyGridTable");
                __builder2.AddMarkupContent(20, @"<div class=""divTableHeading ""><div class=""divTableRow ""><div class=""divTableHead grid20l--"">Creation</div>
                            <div class=""divTableHead grid20l--"">Project name</div>
                            <div class=""divTableHead grid20l--"">Kunde</div>
                            <div class=""divTableHead grid20l--"">Poster</div>
                            <div class=""divTableHead grid10c"" style=""background-color:black;"">Actions</div></div></div>
                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "divTableBody ");
#nullable restore
#line 44 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                         foreach (var item in projects)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "divTableRow");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "divTableCell grid20l--");
                __builder2.AddContent(27, 
#nullable restore
#line 47 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                     item.Doc.ToShortDateString()

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "divTableCell grid20l--");
                __builder2.AddContent(31, 
#nullable restore
#line 48 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                     item.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "divTableCell grid20l--");
                __builder2.AddContent(35, 
#nullable restore
#line 49 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                     item.KundeName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "divTableCell grid20l--");
                __builder2.OpenElement(39, "img");
                __builder2.AddAttribute(40, "src", 
#nullable restore
#line 50 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                               item.Poster

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(41, "class", "img128 imageFilter");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n\r\n                                ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "divTableCell grid10c");
                __builder2.OpenElement(45, "a");
                __builder2.AddAttribute(46, "href", "admin/projects/edit/" + (
#nullable restore
#line 53 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                  item.ProjectId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(47, "class", "btn btn-success");
                __builder2.AddContent(48, "Edit General");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                                    ");
                __builder2.OpenElement(50, "a");
                __builder2.AddAttribute(51, "href", "admin/projects/addimages/" + (
#nullable restore
#line 54 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                       item.ProjectId

#line default
#line hidden
#nullable disable
                ) + "/" + (
#nullable restore
#line 54 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                                       item.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "class", "btn btn-success");
                __builder2.AddContent(53, "Manage Images");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(55);
                __builder2.AddAttribute(56, "Roles", "Admin");
                __builder2.AddAttribute(57, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenElement(58, "button");
                    __builder3.AddAttribute(59, "type", "button");
                    __builder3.AddAttribute(60, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                                                                              () => DeleteRecord(item.ProjectId)

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(61, "class", "btn btn-outline-primary");
                    __builder3.AddContent(62, "Delete");
                    __builder3.CloseElement();
                }
                ));
                __builder2.AddAttribute(63, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder3) => {
                    __builder3.OpenComponent<AnimoWeb.Client.Shared.Admin.NotEnough>(64);
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 66 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    <div class=\"divTableFoot tableFootStyle\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "grid100c mt-100");
            __builder.AddMarkupContent(69, "<h6>Projects in Vorarlberg</h6>\r\n    ");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.ProjectList>(70);
            __builder.AddAttribute(71, "Projects", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Projects>>(
#nullable restore
#line 78 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                           inVorarlberg

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "grid100c mt-100");
            __builder.AddMarkupContent(75, "<h6>Projects in rest of Austria</h6>\r\n    ");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.ProjectList>(76);
            __builder.AddAttribute(77, "Projects", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Projects>>(
#nullable restore
#line 82 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                           inRestAustria

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "grid100c mt-100");
            __builder.AddMarkupContent(81, "<h6>International Projects</h6>\r\n    ");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.ProjectList>(82);
            __builder.AddAttribute(83, "Projects", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<Model.Shared.Projects>>(
#nullable restore
#line 86 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
                           inInternational

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\Index.razor"
       

    private List<Projects> projects { get; set; }

    private List<Projects> inVorarlberg { get; set; }
    private List<Projects> inRestAustria { get; set; }
    private List<Projects> inInternational { get; set; }
    private ViewHomeProjectsDTO model = new ViewHomeProjectsDTO();
    private string homeDTO;


    protected async override Task OnInitializedAsync()
    {

        var httpResponse = await repo.Get<List<Projects>>("api/projects");


        if (httpResponse.Error)
        {
            await mostrar.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            projects = httpResponse.Response;
            await ContinueLoading();
        }

    }

    private async Task ContinueLoading()
    {
        var response = await repo.Get<ViewHomeProjectsDTO>($"api/DTOHomeProject");
        model = response.Response;

        inVorarlberg = model.ProjectsInVorarlberg;
        inRestAustria = model.ProjectsInRestAustria;
        inInternational = model.ProjectsInternational;

    }

    private async Task DeleteRecord(int ProjectId)
    {
        var httpResponse = await repo.Delete($"api/projects/{ProjectId}");

        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await mostrar.MostrarMensajeError(body);
        }
        else
        {
            // delete Project TECNOS
            //await DeleteProjectTecnosReference(ProjectId);
            // delete Project PROJECT IMAGES
            //await DeleteProjectImagesReference(ProjectId);
            StateHasChanged();
            await OnInitializedAsync();
        }
    }

    //private async Task DeleteProjectImagesReference(int ProjectId)
    //{
    //    var httpResponse = await repo.Delete($"api/projectimages/{ProjectId}");

    //    if (httpResponse.Error)
    //    {
    //        var body = await httpResponse.GetBody();
    //        await mostrar.MostrarMensajeError(body);
    //    }
    //    else
    //    {
    //        return;
    //    }
    //}

    //private async Task DeleteProjectTecnosReference(int ProjectId)
    //{
    //    var httpResponse = await repo.Delete($"api/projecttecnos/{ProjectId}");

    //    if (httpResponse.Error)
    //    {
    //        var body = await httpResponse.GetBody();
    //        await mostrar.MostrarMensajeError(body);
    //    }
    //    else
    //    {
    //        return;
    //    }
    //}

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMostrarMensajes mostrar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
    }
}
namespace __Blazor.AnimoWeb.Client.Admin.Projects.Index
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

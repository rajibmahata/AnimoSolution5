#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab4f84dd6700f94d66f1a0e3808cf2b9afd72e3"
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
    public partial class ProjectList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "grid100c");
            __Blazor.AnimoWeb.Client.Shared.Admin.ProjectList.TypeInference.CreateGenericList_0(__builder, 2, 3, 
#nullable restore
#line 5 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
                          Projects

#line default
#line hidden
#nullable disable
            , 4, (Projects) => (__builder2) => {
                __builder2.OpenComponent<AnimoWeb.Client.Shared.Admin.ProjectSingle>(5);
                __builder2.AddAttribute(6, "Project", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Model.Shared.Projects>(
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
                                    Projects

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ProjectDelete", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Model.Shared.Projects>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Model.Shared.Projects>(this, 
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
                                                             ProjectDelete

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(8, "ProjectEdit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Model.Shared.Projects>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Model.Shared.Projects>(this, 
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
                                                                                         ProjectEdit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(9, "ProjectView", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Model.Shared.Projects>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Model.Shared.Projects>(this, 
#nullable restore
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
                                                                                                                   ProjectEdit

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 13 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\Admin\ProjectList.razor"
       

    [Parameter] public List<Projects> Projects { get; set; }

    Projects projectToDelete;


    async Task ProjectDelete(Projects project) 
    {
        bool confirmed = await js.InvokeAsync<bool>("confirm", "Are you sure?");
        if (confirmed)
        {
            Projects.Remove(project);
            Console.WriteLine($"Se ha eliminado la pelicula {project.Name}");
        }
    }

    void ProjectEdit() 
    {

    }

    void ProjectView()
    {

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
namespace __Blazor.AnimoWeb.Client.Shared.Admin.ProjectList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::AnimoWeb.Client.Shared.Admin.GenericList<Titem>>(seq);
        __builder.AddAttribute(__seq0, "Listado", __arg0);
        __builder.AddAttribute(__seq1, "HayRegistros", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368f6dc7c7450ea3e3242c58a612183c1228136a"
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
#line 7 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
using Model.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(CmsLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects/addimages/{ProjectId:int}")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/projects/addimages/{ProjectId:int}/{Name}")]
    public partial class AddImages : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "id", "headerSection");
            __builder.AddMarkupContent(2, "<div class=\"grid50l-- vtop\"><h5 class=\"colorBlue\">Projects Images Set</h5>\r\n        <hr class=\"hr4\">\r\n        <div class=\"hh-40 vtop\"><p class=\"p12 colorDarkGrey\">Lets add some Images to our Projects</p></div></div>\r\n\r\n    ");
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
#line 30 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
 if (project == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "Fatal error in project...\r\n    ");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Admin.LoadingAsset>(10);
            __builder.CloseComponent();
#nullable restore
#line 34 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "div");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "class", "p14 pbold");
            __builder.AddContent(14, "Project: ");
            __builder.AddContent(15, 
#nullable restore
#line 38 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                   project.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "p12");
            __builder.AddContent(18, "Actual Images count: ");
            __builder.AddContent(19, 
#nullable restore
#line 38 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                                                           cantidad

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "<br>");
#nullable restore
#line 39 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
     if (cantidad < 1)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<p class=\"colorRed p12\">Project has no images yet !</p>");
#nullable restore
#line 42 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "gridderRow");
            __builder.AddMarkupContent(24, "<br>\r\n            ");
            __builder.AddMarkupContent(25, "<h6>This are the current images</h6><br>");
#nullable restore
#line 48 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
             foreach (var item in projectImagesList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "grid20c");
            __builder.OpenElement(28, "img");
            __builder.AddAttribute(29, "src", 
#nullable restore
#line 51 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                               item.Image.ImageFile

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(30, "class", "img256");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "<br>\r\n                    ");
            __builder.OpenElement(32, "span");
            __builder.AddAttribute(33, "class", "p12 ");
            __builder.AddContent(34, 
#nullable restore
#line 52 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                        item.Image.ImageName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "<br>\r\n                    ");
            __builder.OpenElement(36, "span");
            __builder.AddAttribute(37, "class", "p11 ");
            __builder.AddContent(38, "Order: ");
            __builder.AddContent(39, 
#nullable restore
#line 53 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                               item.Image.order

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "<br>\r\n                    <hr class=\"hr1\">\r\n                    ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                      () => DeleteRecord(item.ImageId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(44, "class", "btn btn-outline-primary");
            __builder.AddContent(45, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 60 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(46, "<hr>\r\n    ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "mt-25");
            __builder.AddMarkupContent(49, "<h6>Adding new Images !</h6>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(50);
            __builder.AddAttribute(51, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 65 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 65 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                               HandleCreate

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(53, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(54);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group");
                __builder2.OpenElement(58, "div");
                __builder2.OpenComponent<AnimoWeb.Client.Shared.Admin.InputImg>(59);
                __builder2.AddAttribute(60, "Label", "Select...");
                __builder2.AddAttribute(61, "ImagenURL", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 69 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                            imageTemp

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "SelectedImage", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#nullable restore
#line 69 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                                                      SelectedImage

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(63, "CssClass", "img1280");
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                ");
                __builder2.OpenElement(65, "div");
                __builder2.AddMarkupContent(66, "<span>Name</span>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "form-control ");
                __builder2.AddAttribute(69, "style", "width: 150px;");
                __builder2.AddAttribute(70, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 73 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                                                         imageName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(71, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => imageName = __value, imageName))));
                __builder2.AddAttribute(72, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => imageName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "style", "width: 150px;");
                __builder2.AddMarkupContent(76, "<span>Position relevance</span>\r\n                    ");
                __Blazor.AnimoWeb.Client.Admin.Projects.AddImages.TypeInference.CreateInputNumber_0(__builder2, 77, 78, "form-control", 79, 
#nullable restore
#line 77 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
                                                                    order

#line default
#line hidden
#nullable disable
                , 80, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => order = __value, order)), 81, () => order);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n\r\n            ");
                __builder2.AddMarkupContent(83, "<button type=\"submit\" class=\"btn btn-primary\">Create</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 86 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "H:\Upwork\New folder\AnimoSolution5-0\AnimoSolution5\Client\Admin\Projects\AddImages.razor"
       
    [Parameter] public int ProjectId { get; set; }
    [Parameter] public string Name { get; set; }

    public Projects project = new Projects();
    public ViewProjectImagesDTO model = new ViewProjectImagesDTO();
    public ProjectImages projectImages = new ProjectImages();
    public List<ProjectImages> projectImagesList = new List<ProjectImages>();

    public Images image = new Images();
    public int cantidad = 0;
    public string imageName;
    public int order;
    private string imageTemp;



    protected async override Task OnInitializedAsync()
    {
        var httpResponse = await repo.Get<ViewProjectImagesDTO>($"api/projectimages/{ProjectId}");

        imageTemp = null;
        image.ImageFile = null;

        if (httpResponse.Error)
        {
            await mostrar.MostrarMensajeError(await httpResponse.GetBody());
        }
        else
        {
            projectImagesList = httpResponse.Response.ProjectImages;
            project = httpResponse.Response.Project;

            if (projectImagesList == null)
            {
                cantidad = 0;
            }
            else
            {
                projectImagesList = httpResponse.Response.ProjectImages;
                cantidad = projectImagesList.Count;
            }
        }

    }

    private void SelectedImage(string imageBase64)
    {
        imageTemp = imageBase64;
        image.ImageFile = null;
    }


    private async Task HandleCreate()
    {

        image.ImageName = imageName;
        image.ImageFile = imageTemp;
        image.order = order;

        //Primero posteamos la imagen
        var httpResponse = await repo.Post<Images,int>("api/images", image);
        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await mostrar.MostrarMensajeError(body);

        }
        else
        {
            //Segundo posteamos los id en la tabla de normalizacion
            projectImages.ProjectId = ProjectId;
            projectImages.ImageId = httpResponse.Response;

            var httpRes2 = await repo.Post($"api/projectimages", projectImages);
            if (httpRes2.Error)
            {
                var body = await httpResponse.GetBody();
                await mostrar.MostrarMensajeError(body);
            }
            else
            {
                StateHasChanged();
                image.ImageFile = null;
                imageTemp = null;
                imageName = "";
                order = 0;                

                nm.NavigateTo($"admin/projects");
            }

        }
    }

    private async Task DeleteRecord(int imageId)
    {
        var httpResponse = await repo.Delete($"api/images/{imageId}");

        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await mostrar.MostrarMensajeError(body);
        }
        else
        {
            // exito
            await DeleteProjectImagesReference(imageId);
            StateHasChanged();
            await OnInitializedAsync();
        }
    }

    private async Task DeleteProjectImagesReference(int imageId)
    {
        var httpResponse = await repo.Delete($"api/projectimages/{imageId}");

        if (httpResponse.Error)
        {
            var body = await httpResponse.GetBody();
            await mostrar.MostrarMensajeError(body);
        }
        else
        {
            // exito 

            //await OnInitializedAsync();
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
namespace __Blazor.AnimoWeb.Client.Admin.Projects.AddImages
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

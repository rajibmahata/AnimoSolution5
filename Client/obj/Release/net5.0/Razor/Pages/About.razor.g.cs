#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d30f9183d5746549e520357705b67a9fcd1ec77"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Pages
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
#nullable restore
#line 4 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
using AnimoWeb.Client.Shared.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
using Model.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/about")]
    public partial class About : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n\r\n    .trapper {\r\n        width: 350px;\r\n        height: 350px;\r\n        background-color: #fff;\r\n        margin: 30px;\r\n        position: relative;\r\n        overflow: hidden;\r\n        border-radius: 6px 6px 6px 6px;\r\n        box-shadow: 0;\r\n        transform: scale(0.90);\r\n        transition: box-shadow 0.5s, transform 0.5s;\r\n        border: 1px solid #ededed;\r\n        box-shadow: 0 0 2px #b2b2b2;\r\n    }\r\n\r\n        .trapper:hover {\r\n            transform: scale(1);\r\n            box-shadow: 0px 0px 15px rgba(0, 0, 0, 0.3);\r\n        }\r\n\r\n        .trapper .kontainer {\r\n            width: 100%;\r\n            height: 100%;\r\n        }\r\n\r\n            .trapper .kontainer .top {\r\n                height: 80%;\r\n                width: 100%;\r\n                -webkit-background-size: 100%;\r\n                -moz-background-size: 100%;\r\n                -o-background-size: 100%;\r\n                background-size: 100%;\r\n            }\r\n\r\n            .trapper .kontainer .bottom {\r\n                width: 200%;\r\n                height: 20%;\r\n                transition: transform 0.5s;\r\n            }\r\n\r\n                .trapper .kontainer .bottom.clicked {\r\n                    transform: translateX(-50%);\r\n                }\r\n\r\n                .trapper .kontainer .bottom .left {\r\n                    height: 80%;\r\n                    width: 50%;\r\n      \r\n                    background: radial-gradient(circle, rgb(250, 250, 250) 10%, rgba(225,230,240,1) 100%) !important; /*227 224*/\r\n                    position: relative;\r\n                    float: left;\r\n               \r\n             \r\n                    opacity: 0.9;\r\n                }\r\n\r\n        .trapper .inside {\r\n            z-index: 9;\r\n         \r\n            background: radial-gradient(circle, rgb(66, 62, 68) 1%, rgb(78, 76, 82) 100%) !important; /*227 224*/\r\n            width: 140px;\r\n            height: 140px;\r\n            position: absolute;\r\n            top: -70px;\r\n            right: -70px;\r\n            border-radius: 0px 0px 200px 200px;\r\n            transition: all 0.5s, border-radius 2s, top 1s;\r\n            overflow: hidden;\r\n            opacity: 0.8;\r\n        }\r\n\r\n            .trapper .inside .icon {\r\n                position: absolute;\r\n                right: 85px;\r\n                top: 80px;\r\n                color: white;\r\n                opacity: 1;\r\n            }\r\n\r\n            .trapper .inside:hover {\r\n                width: 100%;\r\n                right: 0;\r\n                top: 0;\r\n                border-radius: 0;\r\n                height: 80%;\r\n            }\r\n\r\n                .trapper .inside:hover .icon {\r\n                    opacity: 0;\r\n                    right: 15px;\r\n                    top: 15px;\r\n                }\r\n\r\n                .trapper .inside:hover .contents {\r\n                    opacity: 1;\r\n                    transform: scale(1);\r\n                    transform: translateY(0);\r\n                }\r\n\r\n            .trapper .inside .contents {\r\n                padding: 5%;\r\n                opacity: 0;\r\n                transform: scale(0.5);\r\n                transform: translateY(-200%);\r\n                transition: opacity 0.2s, transform 0.8s;\r\n            }\r\n</style>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "grid100c mt-100");
            __builder.AddMarkupContent(3, "<h3 class=\"txtShadow\">Unser Team</h3>\r\n    <br>\r\n    ");
            __builder.AddMarkupContent(4, @"<span class=""p13 colorDarkGrey"">
        Unser hochqualifiziertes Team besteht aus erfahrenen Multimedia-Experten und einer Reihe von qualifizierten Freelancern aus den unterschiedlichsten Bereichen - alles Spezialisten auf ihren jeweiligen Fachgebieten.<br>
        Dadurch sind wir in der Lage, Kundenprojekte professionell, flexibel und präzise umzusetzen. Unsere langjährige Erfahrung garantiert die Einhaltung von Budget und Terminen.<br>
        Wir arbeiten mit engagierten und hochmotivierten Profis, die wissen auf was es ankommt!<br>
        <br>
        <span class=""pbold"">Wir bieten Studenten aus Medienfachrichtungen die Möglichkeit, bei uns ein Praktikum zu absolvieren.</span></span>
    <br>
    <br>

    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "id", "employees");
            __builder.AddAttribute(7, "class", "mt-50 grid100c--");
#nullable restore
#line 133 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
         if (Employees == null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<span>No records found...</span>");
#nullable restore
#line 136 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
        }
        else
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 140 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
             foreach (var item in Employees)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "trapper mt-25 grid25c--");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "kontainer ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "top");
            __builder.OpenElement(15, "img");
            __builder.AddAttribute(16, "src", 
#nullable restore
#line 145 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
                                       item.UserPoster

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(17, "class", "imgResponsive imageFilterAbout");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "bottom");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "left");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "details mt-5");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "p14 pbold colorDarkGrey");
            __builder.AddContent(27, 
#nullable restore
#line 150 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
                                                                           item.FullName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<br>\r\n                                    ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "p13 colorDarkGrey");
            __builder.OpenElement(31, "i");
            __builder.AddContent(32, 
#nullable restore
#line 151 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
                                                                        item.JobPosition

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                    ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "inside grid100c");
            __builder.AddMarkupContent(36, "<div class=\"icon\"><i class=\"icon-search-plus fa-2x\"></i></div>\r\n                        ");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "contents");
            __builder.AddAttribute(39, "style", "text-align: left;");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "icon-arrow-circle-o-right colorWhite fa-2x");
            __builder.AddMarkupContent(42, "<br>\r\n                            ");
            __builder.OpenElement(43, "span");
            __builder.AddAttribute(44, "class", "pl-5 colorWhite p10 vtop");
            __builder.AddContent(45, 
#nullable restore
#line 162 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
                                                                    item.Email

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "<br>\r\n                            ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "icon-phone colorWhite fa-2x");
            __builder.AddMarkupContent(49, "<br>\r\n                            ");
            __builder.OpenElement(50, "span");
            __builder.AddAttribute(51, "class", "pl-5 colorWhite p10 vtop");
            __builder.AddContent(52, 
#nullable restore
#line 164 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
                                                                     item.Phone

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 168 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
             

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n    ");
            __builder.AddMarkupContent(54, @"<div class=""mt-100""><h3>Bewerbungen</h3>
        <br>
        <span>
            Wir sind immer an talentierten 3D-Artists mit einer Passion für Details interessiert. <br>
            Bewerbungen mit Arbeitsproben (!), einem kurzen Lebenslauf mit Foto senden Sie bitte an unser Büro in Mäder oder an die unten angeführte E-Mail-Adresse.
        </span>
        <br><br>
        <h6 class=""colorRed"">jobs@animations-and-more.com</h6></div>");
#nullable restore
#line 186 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
     if (Employees != null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<h4 class=\"mt-100\"></h4>\r\n        ");
            __builder.AddMarkupContent(56, @"<div class=""gridderRow grid100c-- ""><div class=""grid100c--""><h4 class=""colorDarkGrey txtShadow"">Buro Wien</h4>
                <br>
                <img src=""/images/identity/AnimoWien.jpg"" alt=""Animations and More in Wien"" class=""imgResponsive imageFilter imgBorder100""></div>
            <div class=""grid100c-- mt-50""><h4 class=""colorDarkGrey txtShadow"">Buro Vorarlberg</h4>
                <br>
                <img src=""/images/identity/AnimoMader.jpg"" alt=""Animations and More in Vorarlberg"" class=""imgResponsive imageFilter imgBorder100""></div></div>");
#nullable restore
#line 204 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(57, "<br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n<div class=\"mt-150\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 215 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\About.razor"
       

    public List<Users> Employees { get; set; }


    private int paginaActual = 1;
    private int paginasTotales;

    private async Task paginaSeleccionada(int pagina)
    {
        paginaActual = pagina;
        await Load(pagina);
    }


    protected override async Task OnInitializedAsync()
    {

        await Load();
    }


    private async Task Load(int pagina = 1)
    {
        var responseHttp = await repo.Get<List<Users>>($"api/users?pagina={pagina}");

        if (!responseHttp.Error)
        {
            Employees = responseHttp.Response;
            var conteo = responseHttp.HttpResponseMessage.Headers.GetValues("conteo").FirstOrDefault();
            paginasTotales = int.Parse(responseHttp.HttpResponseMessage.Headers.GetValues("totalPaginas").FirstOrDefault());
        }

    }








#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
    }
}
#pragma warning restore 1591

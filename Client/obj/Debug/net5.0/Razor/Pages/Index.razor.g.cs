#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e5db1d96a9f3b11ef83cf3b4a3e2f4a0a9c235a"
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
#line 8 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
using AnimoWeb.Client.Shared.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
using Model.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .btn {
        position: relative;
        z-index: 9999;
    }

    #topThree {
        position: fixed;
        left: -15px;
        top: 150px;
        width: 100%;
        height: 100%;
        background-position: 100% 100%;
        background-repeat: no-repeat;
        z-index: 98 !important;
    }
</style>

");
            __builder.AddMarkupContent(1, @"<div class=""grid100c""><span class=""p14 colorDarkGrey"">
        Seit mehr als <span class=""colorRed pbold txtShadow"">20 Jahren</span> erstellen wir qualitativ hochwertige 3D Visualisierungen, Animationen und AR|VR-Anwendungen für Industriekunden, <br>
        Filmproduktionen, Bauträger, Architekten und Werbeagenturen in <span class=""pbold colorDarkGrey txtShadow"">ganz Europa</span>.
    </span>
    <br><br>

    <div class=""wordCarousel mt-50""><span class=""p12 colorDarkGrey"">We feed the Robot with</span>
        <div><ul class=""flip4 p22 pbold colorRed""><li>Updates</li>
                <li>Technology</li>
                <li>Responsability</li>
                <li>Screws</li>
                <li>Some oils</li>
                <li class=""colorRed"">Love</li></ul></div></div></div>


");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Web.AnzeigeMsg>(2);
            __builder.AddAttribute(3, "onCloseAnzeige", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 52 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                            CloseAnzeige

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "animoBilboard", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                                                                             animoBilboard

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(5, (__value) => {
#nullable restore
#line 52 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                                                _anzeigeMsg = (AnimoWeb.Client.Shared.Web.AnzeigeMsg)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n\r\n");
            __builder.OpenComponent<AnimoWeb.Client.Shared.Web.CookieMsg>(7);
            __builder.AddAttribute(8, "onCancel", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                     CloseCookie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "onConfirm", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 55 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                                             CloseCookie

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(10, (__value) => {
#nullable restore
#line 55 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
                                                                _cookies = (AnimoWeb.Client.Shared.Web.CookieMsg)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(11, "\r\n\r\n<div class=\"gridderRow grid100c mt-100\"></div>\r\n<div id=\"particles-js\" class=\"pJS_canvas_class\"></div>\r\n<div id=\"topThree\"></div>\r\n\r\n<div class=\"mt-500\"></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 68 "H:\Upwork\New folder\AnimoSolution5-0\Client\Pages\Index.razor"
       

    string name = string.Empty;
    IJSObjectReference moduleUtils;
    CookieMsg _cookies;
    AnzeigeMsg _anzeigeMsg;
    public bool showAnzeigeState = false;
    private bool isAnythingToShowFromDb = true;

    Bilboard bilboard;
    public string animoBilboard = "";



    public async Task Open()
    {
        await Task.Delay(5000);

        if (isAnythingToShowFromDb)
        {
            var isBilboardAskedToBeClosed = await SessionStorage.GetItemAsync<bool>("PleaseCloseBilboard");
            if (isBilboardAskedToBeClosed)
            {
                _anzeigeMsg.Ocultar();
            }
            else
            {
                _anzeigeMsg.Mostrar();
                StateHasChanged();
                showAnzeigeState = true;
            }
        }
        else
        {
            _anzeigeMsg.Ocultar();
        }

    }


    protected override async Task OnInitializedAsync()
    {
        var httpRequest = await repo.Get<Bilboard>("api/anzeige");
        if (httpRequest.Response == null)
        {
            isAnythingToShowFromDb = false;
        }
        else
        {
            animoBilboard = httpRequest.Response.BilboardFile;
            isAnythingToShowFromDb = true;
        }

        var cookieAccepted = await LocalStorage.GetItemAsync<bool>("cookieAccepted");
        if (cookieAccepted)
        {
            _cookies.Ocultar();

        }

    }




    protected override async Task OnAfterRenderAsync(bool firstRender)
    {

        if (firstRender)
        {
            await jsRuntime.InvokeVoidAsync("particlesJS");
            moduleUtils = await jsRuntime.InvokeAsync<IJSObjectReference>("import", "./3d/Main.js"); // Modulo

            await moduleUtils.InvokeVoidAsync("AnimoLoader");
        }
        await Open();
    }

    async void CloseCookie()
    {
        await LocalStorage.SetItemAsync<bool>("cookieAccepted", true);
        _cookies.Ocultar();
        StateHasChanged();
    }
    async void CloseAnzeige()
    {
        await SessionStorage.SetItemAsync<bool>("PleaseCloseBilboard", true);
        _anzeigeMsg.Ocultar();
        showAnzeigeState = false;
        StateHasChanged();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService SessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.LocalStorage.ILocalStorageService LocalStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nm { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IRepository repo { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
    }
}
#pragma warning restore 1591

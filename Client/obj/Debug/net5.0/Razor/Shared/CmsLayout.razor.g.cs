#pragma checksum "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\CmsLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a26b40735d678324c32fa676289a3fbdb33882a7"
// <auto-generated/>
#pragma warning disable 1591
namespace AnimoWeb.Client.Shared
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
#line 2 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\CmsLayout.razor"
using AnimoWeb.Client.Shared.Admin;

#line default
#line hidden
#nullable disable
    public partial class CmsLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-e8o4hhmwk6");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(3);
            __builder.AddAttribute(4, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(5, "div");
                __builder2.AddAttribute(6, "class", "sidebar");
                __builder2.AddAttribute(7, "b-e8o4hhmwk6");
                __builder2.OpenComponent<AnimoWeb.Client.Shared.Admin.AdminNavMenu>(8);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "main");
                __builder2.AddAttribute(12, "b-e8o4hhmwk6");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "grid100r pl-25 pr-25");
                __builder2.AddAttribute(15, "b-e8o4hhmwk6");
                __builder2.OpenElement(16, "span");
                __builder2.AddAttribute(17, "class", "p12 colorDarkGrey pr-10");
                __builder2.AddAttribute(18, "b-e8o4hhmwk6");
                __builder2.AddContent(19, 
#nullable restore
#line 13 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\CmsLayout.razor"
                                                           context.User.Identity.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.OpenComponent<AnimoWeb.Client.Shared.Admin.LogoutButton>(20);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n                ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "grid100l pl-25 pr-25");
                __builder2.AddAttribute(24, "b-e8o4hhmwk6");
                __builder2.AddContent(25, 
#nullable restore
#line 16 "H:\Upwork\New folder\AnimoSolution5-0\Client\Shared\CmsLayout.razor"
                     Body

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n                ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "mt-100");
                __builder2.AddAttribute(29, "b-e8o4hhmwk6");
                __builder2.OpenComponent<AnimoWeb.Client.Shared.Admin.Admin_Footer>(30);
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.AddAttribute(31, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "grid100c");
                __builder2.AddAttribute(34, "b-e8o4hhmwk6");
                __builder2.OpenComponent<AnimoWeb.Client.Admin.Login>(35);
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c835e0119d1017d6cec15bbaec6cbb4606978b43"
// <auto-generated/>
#pragma warning disable 1591
namespace TicketSystem.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using TicketSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using TicketSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using BlazorInputFile;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-u7vak8vfra");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-u7vak8vfra");
            __builder.OpenComponent<TicketSystem.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-u7vak8vfra");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "top-row px-4 auth");
            __builder.AddAttribute(13, "b-u7vak8vfra");
            __builder.OpenComponent<TicketSystem.Shared.LoginDisplay>(14);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "content px-4");
            __builder.AddAttribute(18, "b-u7vak8vfra");
            __builder.AddContent(19, 
#nullable restore
#line 14 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d99cc32b74e4372f3291dd79d37dc6de771df04f"
// <auto-generated/>
#pragma warning disable 1591
namespace TicketSystem.Pages
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
#nullable restore
#line 2 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Counter.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 6 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

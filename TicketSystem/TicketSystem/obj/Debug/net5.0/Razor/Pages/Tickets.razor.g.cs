#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b47f9bb649f102739e00885a86b162844c3bd84"
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
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using TicketSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using TicketSystem.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\_Imports.razor"
using Syncfusion.Blazor.DropDowns;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
using TicketSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/tickets")]
    public partial class Tickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Tickets</h1>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                          NavigateToCreateTicket

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Create New");
            __builder.CloseElement();
#nullable restore
#line 8 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
 if (TicketList is null)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p><em>Loading.... !</em></p>");
#nullable restore
#line 11 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(6);
            __builder.AddAttribute(7, "Roles", "Junior");
            __builder.CloseComponent();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(9);
            __builder.AddAttribute(10, "Roles", "MidLevel");
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n    able to see midlevel\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(14);
            __builder.AddAttribute(15, "Roles", "Senior");
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(17, "\r\n    able to see senior\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(18, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Roles", "OfficeSupport");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n    able to see officesupport\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "Roles", "TechSupport");
            __builder.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(27, "\r\n    able to see techsupport\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(28, "\r\n\r\n");
            __builder.OpenElement(29, "table");
            __builder.AddMarkupContent(30, "<thead><tr><th>Id</th>\r\n            <th>Title</th>\r\n            <th>Content</th>\r\n            <th>ImageUrl</th>\r\n            <th>Visibility</th>\r\n            <th>RefersTo</th>\r\n            <th>Action</th></tr></thead>\r\n    ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 42 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
         foreach(var ticket in TicketList)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 45 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.TicketId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 46 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 47 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                    ");
            __builder.OpenElement(42, "td");
            __builder.AddContent(43, 
#nullable restore
#line 48 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 49 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.Visibility

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                    ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 50 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.RefersTo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.AddMarkupContent(51, "<td><a class=\"nav-link\" href=\"#\"><span class=\"oi oi-pencil\" aria-hidden=\"true\">Edit</span></a>\r\n                        <a class=\"nav-link\" href=\"#\"><span class=\"oi oi-trash\" aria-hidden=\"true\">Delete</span></a></td>");
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
      
    List<Ticket> TicketList = new();
    protected override async Task OnInitializedAsync()
    {
        TicketList = await Task.Run(() => ticketService.GetAllTicketsAsync());
    }

    private void NavigateToCreateTicket()
    {
        NavigationManager.NavigateTo("/createticket");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
    }
}
#pragma warning restore 1591
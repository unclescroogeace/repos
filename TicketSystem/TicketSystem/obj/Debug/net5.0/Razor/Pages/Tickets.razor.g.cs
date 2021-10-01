#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9069c7f58d784bbbba1779326b6c7c43cab264c0"
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
#line 4 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tickets")]
    public partial class Tickets : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Tickets</h1>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "Roles", "Junior, Senior, MidLevel");
            __builder.AddAttribute(3, "Authorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "button");
                __builder2.AddAttribute(5, "class", "btn btn-primary");
                __builder2.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                                  NavigateToCreateTicket

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(7, "Create New");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
 if (TicketList is null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(8, "<p><em>Loading.... !</em></p>");
#nullable restore
#line 20 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Id</th>\r\n            <th>Title</th>\r\n            <th>Visibility</th>\r\n            <th>RefersTo</th>\r\n            <th>Action</th></tr></thead>\r\n    ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 33 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
         foreach (var ticket in TicketList)
        {
            if (ticket.Visibility == 1 || ticket.UserId == loggedInUser.Id || ticket.RefersTo == loggedInUser.Role)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 38 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.TicketId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/ViewTicket/" + (
#nullable restore
#line 39 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                              ticket.TicketId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 39 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                                                ticket.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 40 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.Visibility

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "td");
            __builder.AddContent(25, 
#nullable restore
#line 41 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         ticket.RefersTo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.AddMarkupContent(27, "<td><a class=\"nav-link\" href=\"#\"><span class=\"oi oi-pencil\" aria-hidden=\"true\">Edit</span></a>\r\n                        <a class=\"nav-link\" href=\"#\"><span class=\"oi oi-trash\" aria-hidden=\"true\">Delete</span></a></td>");
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
            }
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
      
    List<Ticket> TicketList = new();
    AspNetUser loggedInUser = new();


    private Task<AspNetUser> GetCurrentUserAsync() => userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

    protected override async Task OnInitializedAsync()
    {
        TicketList = await Task.Run(() => ticketService.GetAllTicketsAsync());
        loggedInUser = await Task.Run(() => GetCurrentUserAsync());

    }

    private void NavigateToCreateTicket()
    {
        NavigationManager.NavigateTo("/createticket");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UserManager<AspNetUser> userManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
    }
}
#pragma warning restore 1591

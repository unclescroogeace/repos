#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01486c2a0fd43887373d673d696ec79fdbca10ef"
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
                __builder2.AddAttribute(5, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(6, "id", "createButton");
                __builder2.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                                                            NavigateToCreateTicket

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(8, "Create New");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(9, "<br><br>");
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
            __builder.AddMarkupContent(10, "<p><em>Loading.... !</em></p>");
#nullable restore
#line 20 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, "<thead class=\"thead-light\"><tr><th scope=\"col\">Title</th>\r\n            <th scope=\"col\">Author</th></tr></thead>\r\n    ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 30 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
         foreach (var ticket in TicketList)
        {
            if (ticket.Visibility == 2 || ticket.UserId == loggedInUser.Id || ticket.RefersTo == loggedInUser.Role)
            {
                authorInfo = userService.GetUser(ticket.UserId);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/ViewTicket/" + (
#nullable restore
#line 36 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                              ticket.TicketId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, 
#nullable restore
#line 36 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
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
#line 37 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                         authorInfo.Firstname

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(23, " ");
            __builder.AddContent(24, 
#nullable restore
#line 37 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
                                               authorInfo.Lastname

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
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
#line 44 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\Tickets.razor"
      
    List<Ticket> TicketList = new();
    AspNetUser loggedInUser = new();
    AspNetUser authorInfo = new();


    private Task<AspNetUser> GetCurrentUserAsync() => userManager.GetUserAsync(httpContextAccessor.HttpContext.User);

    protected override async Task OnInitializedAsync()
    {
        TicketList = await Task.Run(() => ticketService.GetAllTicketsAsync());
        loggedInUser = await Task.Run(() => GetCurrentUserAsync());
    }

    private void NavigateToCreateTicket()
    {
        NavigationManager.NavigateTo("/CreateTicket");
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

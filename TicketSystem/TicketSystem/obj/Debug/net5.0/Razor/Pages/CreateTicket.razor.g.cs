#pragma checksum "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f031efd849282c423e77b153e9a9401aaaaeb84c"
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
#line 3 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
using TicketSystem.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
using TicketSystem.Utility;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/createticket")]
    public partial class CreateTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateTicket</h3>\r\n\r\n");
            __builder.OpenElement(1, "form");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-8");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "form-group");
            __builder.AddMarkupContent(8, "<label for=\"Title\" class=\"custom-control-label\">Title</label>\r\n                ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "form", "Title");
            __builder.AddAttribute(11, "class", "form-control");
            __builder.AddAttribute(12, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                                                ticket.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Title = __value, ticket.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"Content\" class=\"custom-control-label\">Content</label>\r\n                ");
            __builder.OpenElement(18, "textarea");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "id", "textAreaContent");
            __builder.AddAttribute(21, "rows", "4");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 20 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                                                                    ticket.Content

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Content = __value, ticket.Content));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label for=\"RefersTo\" class=\"custom-control-label\"></label>\r\n                ");
            __builder.OpenElement(28, "select");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                ticket.RefersTo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.RefersTo = __value, ticket.RefersTo));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value");
            __builder.AddContent(34, "-- Refers to --");
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                    ");
            __builder.OpenElement(36, "option");
            __builder.AddAttribute(37, "value", "OfficeSupport");
            __builder.AddContent(38, "Office Support");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                    ");
            __builder.OpenElement(40, "option");
            __builder.AddAttribute(41, "value", "TechSupport");
            __builder.AddContent(42, "TechSupport");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group");
            __builder.AddMarkupContent(46, "<label for=\"Visibility\" class=\"custom-control-label\"></label>\r\n                ");
            __builder.OpenElement(47, "select");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 32 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                ticket.Visibility

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticket.Visibility = __value, ticket.Visibility));
            __builder.SetUpdatesAttributeName("value");
            __builder.OpenElement(51, "option");
            __builder.AddAttribute(52, "value");
            __builder.AddContent(53, "-- Visibility --");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                    ");
            __builder.OpenElement(55, "option");
            __builder.AddAttribute(56, "value", "0");
            __builder.AddContent(57, "Only for me");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                    ");
            __builder.OpenElement(59, "option");
            __builder.AddAttribute(60, "value", "1");
            __builder.AddContent(61, "For Everyone");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n    ");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "row");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "col-md-4");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "form-group");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "button");
            __builder.AddAttribute(71, "class", "btn btn-primary");
            __builder.AddAttribute(72, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                                                        Create

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "value", "Save");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                ");
            __builder.OpenElement(75, "input");
            __builder.AddAttribute(76, "type", "button");
            __builder.AddAttribute(77, "class", "btn btn-primary");
            __builder.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
                                                                        Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(79, "value", "Cancel");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Krasimir Kostadinov\source\repos\TicketSystem\TicketSystem\Pages\CreateTicket.razor"
       
    Ticket ticket = new();
    protected async void Create()
    {
        ticket.UserId = httpContextAccessor.HttpContext.User.GetUserId();
        ticket.ImageUrl = "urlhere";
        await ticketService.CreateTicket(ticket);
        NavigationManager.NavigateTo("tickets");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("tickets");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor httpContextAccessor { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITicketService ticketService { get; set; }
    }
}
#pragma warning restore 1591

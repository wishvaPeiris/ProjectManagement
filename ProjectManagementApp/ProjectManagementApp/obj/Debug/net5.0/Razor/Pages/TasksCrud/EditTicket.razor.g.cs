#pragma checksum "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "465d8e63871d64c49b0b8f5605f057d121266cac"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementApp.Pages.TasksCrud
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
    public partial class EditTicket : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show");
            __builder.AddAttribute(2, "id", "myModal");
            __builder.AddAttribute(3, "style", "display:block; background-color: rgba(10,10,10,.8);");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.AddAttribute(5, "role", "dialog");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "modal-dialog");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Edit Ticket</h5>\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn btn-close");
            __builder.AddAttribute(16, "data-bs-dismiss", "modal");
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                                                            ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n      ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "modal-body");
            __builder.OpenElement(22, "form");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "mb-3");
            __builder.AddMarkupContent(25, "<label for=\"recipient-name\" class=\"col-form-label\">Ticket Title:</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "id", "recipient-name");
            __builder.AddAttribute(30, "placeholder", 
#nullable restore
#line 17 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                                                                   ticket.taskTitle

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                                        ticketTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticketTitle = __value, ticketTitle));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n          ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "mb-3");
            __builder.AddMarkupContent(36, "<label for=\"message-text\" class=\"col-form-label\">Ticket Description:</label>\r\n            ");
            __builder.OpenElement(37, "textarea");
            __builder.AddAttribute(38, "id", "company_descriptiopn");
            __builder.AddAttribute(39, "class", "form-control");
            __builder.AddAttribute(40, "placeholder", 
#nullable restore
#line 21 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                                                                                     ticket.taskDescription

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(41, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                       ticketDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(42, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => ticketDescription = __value, ticketDescription));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n      ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "modal-footer");
            __builder.OpenElement(46, "button");
            __builder.AddAttribute(47, "type", "button");
            __builder.AddAttribute(48, "class", "btn btn-secondary");
            __builder.AddAttribute(49, "data-bs-dismiss", "modal");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                                           ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "type", "button");
            __builder.AddAttribute(55, "class", "btn btn-primary");
            __builder.AddAttribute(56, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
                                                                 ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(57, "Save Ticket");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\EditTicket.razor"
       
    public Ticket ticket = new Ticket();
    private bool result = false;

    [Parameter]
    public int ticketID { get; set; }

    public string ticketTitle { get; set; }
    public string ticketDescription { get; set; }
    private DateTime createdDate = DateTime.Today;


    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    protected async override Task OnInitializedAsync()
    {
        ticket = TicketService.Get(ticketID);
    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        ticket.taskTitle = ticketTitle;
        ticket.taskDescription = ticketDescription;

        result = TicketService.Upate(ticket);

        if (result)
         {
            ToastService.ShowSuccess("Task is updated successfully", "Success!");
         }
        else
          {
            ToastService.ShowError("Something went wrong when updating the task", "Error");
          }
         return OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskService TicketService { get; set; }
    }
}
#pragma warning restore 1591

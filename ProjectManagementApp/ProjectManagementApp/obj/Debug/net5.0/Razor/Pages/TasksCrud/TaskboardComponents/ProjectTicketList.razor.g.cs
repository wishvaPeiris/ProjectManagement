#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9c1ecb174eb0c2e4cc639dae19577159f76f0d"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementApp.Pages.TasksCrud.TaskboardComponents
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using ProjectManagementApp.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\_Imports.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
using DataAccess.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
    public partial class ProjectTicketList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "job-status");
            __builder.OpenElement(2, "h3");
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
__builder.AddContent(3, ListStatus);

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, " (");
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
__builder.AddContent(5, Tickets.Count());

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "ul");
            __builder.AddAttribute(9, "class", "dropzone" + " " + (
#nullable restore
#line 7 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
                         dropClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "ondragover", "event.preventDefault();");
            __builder.AddAttribute(11, "ondragstart", "event.dataTransfer.setData(\'\', event.target.id);");
            __builder.AddAttribute(12, "ondrop", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
                 HandleDrop

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "ondragenter", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
                      HandleDragEnter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "ondragleave", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.DragEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
                      HandleDragLeave

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line 14 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
         foreach (var ticket in Tickets)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.TasksCrud.TaskboardComponents.ProjectTicket>(15);
            __builder.AddAttribute(16, "Ticket", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Model.Ticket>(
#nullable restore
#line 16 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
                                   ticket

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 17 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskboardComponents\ProjectTicketList.razor"
       

    [CascadingParameter] TicketContainer Container { get; set; }
    [Parameter] public TicketStatus ListStatus { get; set; }
    [Parameter] public TicketStatus[] AllowedStatuses { get; set; }

    List<Ticket> Tickets = new List<Ticket>();
    string dropClass = "";

    protected override void OnParametersSet()
    {
        Tickets.Clear();
        Tickets.AddRange(Container.Tickets.Where(x => x.taskStatus == ListStatus));
    }

    private void HandleDragEnter()
    {
        if (ListStatus == Container.Payload.taskStatus) return;

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.taskStatus))
        {
            dropClass = "no-drop";
        }
        else
        {
            dropClass = "can-drop";
        }
    }

    private void HandleDragLeave()
    {
        dropClass = "";
    }

    private async Task HandleDrop()
    {
        dropClass = "";

        if (AllowedStatuses != null && !AllowedStatuses.Contains(Container.Payload.taskStatus)) return;

        await Container.UpdateJobAsync(ListStatus);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
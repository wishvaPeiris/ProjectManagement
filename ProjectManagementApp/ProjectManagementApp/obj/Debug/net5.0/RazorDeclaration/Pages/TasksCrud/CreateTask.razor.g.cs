// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\CreateTask.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\CreateTask.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
    public partial class CreateTask : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Mahen\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\CreateTask.razor"
       
    public Ticket ticket = new Ticket();
    private bool result = false;

    [Parameter]
    public int projectId { get; set; }

    public string ticketTitle { get; set; }
    public string ticketDescription { get; set; }
    private DateTime createdDate = DateTime.Today;


    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    protected async override Task OnInitializedAsync()
    {

    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        ticket.taskTitle = ticketTitle;
        ticket.taskDescription = ticketDescription;
        ticket.projectId = projectId;
        ticket.taskCreateDate = createdDate;
        ticket.taskStatus = DataAccess.Enums.TicketStatus.New;

        result = TicketService.createTicket(ticket);

        if (result)
        {
            NavigationManager.NavigateTo("/company");
            ToastService.ShowSuccess("Task is added successfully", "Success!");
        }
        else
        {
            ToastService.ShowError("Something went wrong when adding the task", "Error");
        }
        StateHasChanged();
        return OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskService TicketService { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e66149111286bd599afc0736905cad809affcbe"
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
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
using DataAccess.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
using ProjectManagementApp.Pages.TasksCrud.TaskboardComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
           [Authorize(Policy = "DeveloperOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/taskboard")]
    public partial class TaskBoard : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "task-board-heading");
            __builder.AddMarkupContent(2, "<h3>Project Task board</h3>\r\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-dark");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                openCreateDialog

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Create Task");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n       ");
            __builder.OpenComponent<ProjectManagementApp.Pages.TasksCrud.TaskboardComponents.TicketContainer>(8);
            __builder.AddAttribute(9, "Tickets", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.List<DataAccess.Model.Ticket>>(
#nullable restore
#line 14 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                 Tickets

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnStatusUpdated", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<DataAccess.Model.Ticket>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<DataAccess.Model.Ticket>(this, 
#nullable restore
#line 14 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                           HandleStatusUpdated

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<ProjectManagementApp.Pages.TasksCrud.TaskboardComponents.ProjectTicketList>(12);
                __builder2.AddAttribute(13, "ListStatus", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus>(
#nullable restore
#line 15 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                           TicketStatus.New

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "AllowedStatuses", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus[]>(
#nullable restore
#line 15 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                                                new TicketStatus[] { TicketStatus.Progress}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n            ");
                __builder2.OpenComponent<ProjectManagementApp.Pages.TasksCrud.TaskboardComponents.ProjectTicketList>(16);
                __builder2.AddAttribute(17, "ListStatus", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus>(
#nullable restore
#line 16 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                           TicketStatus.Progress

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "AllowedStatuses", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus[]>(
#nullable restore
#line 16 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                                                     new TicketStatus[] { TicketStatus.New}

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.OpenComponent<ProjectManagementApp.Pages.TasksCrud.TaskboardComponents.ProjectTicketList>(20);
                __builder2.AddAttribute(21, "ListStatus", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus>(
#nullable restore
#line 17 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                           TicketStatus.Complete

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "AllowedStatuses", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<DataAccess.Enums.TicketStatus[]>(
#nullable restore
#line 17 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                                                     new TicketStatus[] { TicketStatus.Progress }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n<hr>\r\n");
            __builder.OpenElement(24, "p");
            __builder.AddContent(25, "Last updated job was: ");
            __builder.OpenElement(26, "strong");
#nullable restore
#line 20 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
__builder.AddContent(27, lastUpdatedJob);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n<hr>\r\n\r\n");
            __builder.OpenElement(29, "div");
#nullable restore
#line 24 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
 if (EditDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.TasksCrud.CreateTask>(30);
            __builder.AddAttribute(31, "projectId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 26 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                projectID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 26 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
                                                       onCreateDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\TasksCrud\TaskBoard.razor"
       

    List<Ticket> Tickets = new List<Ticket>();
    public bool EditDialogOpen { get; set; }
    public int projectID { get; set; }

    string lastUpdatedJob = "";
    private string checkName;

    [CascadingParameter]
    private Task<AuthenticationState> _authenticationState { get; set; }
    private AuthenticationState authState;

    protected async override Task OnInitializedAsync()
    {
        authState = await _authenticationState;
        checkName = authState.User.Identity.Name;

        var project = Userservice.GetByEmail(checkName);
        projectID = project.projectId;
        Tickets = TicketService.listOfTicketsForProject(project.projectId);
    }

    void HandleStatusUpdated(Ticket updateTicket)
    {
        lastUpdatedJob = updateTicket.taskDescription;

        // from here the ticket status can be updated after each change
    }

    private void onCreateDialogClose(bool accepted)
    {
        EditDialogOpen = false;
        StateHasChanged();
    }

    private void onCreateDialogOpen()
    {
        EditDialogOpen = true;
        StateHasChanged();
    }

    private void openCreateDialog()
    {
        onCreateDialogOpen();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ITaskService TicketService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser Userservice { get; set; }
    }
}
#pragma warning restore 1591

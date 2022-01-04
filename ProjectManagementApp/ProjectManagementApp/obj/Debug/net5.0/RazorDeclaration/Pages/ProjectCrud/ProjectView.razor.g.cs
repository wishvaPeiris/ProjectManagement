// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ProjectManagementApp.Pages.ProjectCrud
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
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project")]
    public partial class ProjectView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
       
    public int count = 0;
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public int projectId { get; set; }
    List<Project> projectList = new List<Project>();
    List<Developer> userList = new List<Developer>();
    List<Company> listOfCompanies = new List<Company>();
    List<string> companyName = new List<string>();
    List<int> listOfUsers = new List<int>();

    protected async override Task OnInitializedAsync()
    {
        listOfCompanies = companyService.listOfCompanies();
        projectList = projectService.listOfProjects();
        userList = userService.listOfUsers();


        foreach (var item in projectList)
        {
            var userLinqQuery = from value in userList where value.projectId == item.projectId select value.Email.ToList();
            listOfUsers.Add(userLinqQuery.Count());

            //getting the company name
            var myLinqQuery = from value in listOfCompanies where value.Id == item.companyProjectId select value.CompanyName.ToString();
            companyName.Add(myLinqQuery.FirstOrDefault());
        }
    }

    private void onEditDialogClose(bool accepted)
    {
        EditDialogOpen = false;
        StateHasChanged();
    }

    private void onEditDialogOpen()
    {
        EditDialogOpen = true;
        StateHasChanged();
    }

    private void openEditDialog(int ButtonId)
    {
        projectId = ButtonId;
        onEditDialogOpen();
    }

    private void onDeleteDialogClose(bool accepted)
    {
        DeleteDialogOpen = false;
        StateHasChanged();
    }

    private void onDeleteDialogOpen()
    {
        DeleteDialogOpen = true;
        StateHasChanged();
    }

    private void openDeletDialog(int ButtonId)
    {
        projectId = ButtonId;
        onDeleteDialogOpen();
    }


    private void addNewProject()
    {
        NavigationManager.NavigateTo("/project/add");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService projectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService companyService { get; set; }
    }
}
#pragma warning restore 1591

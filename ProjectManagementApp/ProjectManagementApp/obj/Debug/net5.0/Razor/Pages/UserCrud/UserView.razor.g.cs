#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99b2dbfc3ea44c8a7d1820cacfd1c7a471877f0e"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementApp.Pages.UserCrud
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
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user")]
    public partial class UserView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>UserView</h3>\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-dark");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                           addNewUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(4, "<i class=\"material-icons\">add</i>Add user");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "container");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "section1");
            __builder.AddMarkupContent(10, "<h3>List of all the projects</h3>\r\n        ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
            __builder.AddMarkupContent(13, @"<thead><tr><th scope=""col"">No</th>
              <th scope=""col"">User Name</th>
              <th scope=""col"">Email</th>
              <th scope=""col"">Contact No</th>
              <th scope=""col"">User Company</th>
              <th scope=""col"">User Projects Count</th>
              <th scope=""col"">User Manager</th></tr></thead>
          ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 30 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                 foreach (var item in userList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "scope", "row");
#nullable restore
#line 33 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(18, item.Id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                      ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 34 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(21, item.UserName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                      ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 35 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(24, item.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                      ");
            __builder.OpenElement(26, "td");
#nullable restore
#line 36 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(27, item.userContactNo);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                      ");
            __builder.OpenElement(29, "td");
#nullable restore
#line 37 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(30, companyName[userList.IndexOf(item)]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                      ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "table");
#nullable restore
#line 40 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                var projectLinqQuery = from value in projectList where value.projectId == item.projectId select new {item.Id,value.projectName };

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                               foreach (var projName in projectLinqQuery)
                             {
                                 if(projName.Id == item.Id){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
#nullable restore
#line 45 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
__builder.AddContent(36, projName.projectName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                 }
                             }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                      ");
            __builder.OpenElement(38, "td");
            __builder.OpenElement(39, "button");
            __builder.AddAttribute(40, "type", "button");
            __builder.AddAttribute(41, "class", "btn btn-success");
            __builder.AddAttribute(42, "id", 
#nullable restore
#line 52 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(43, "data-bs-toggle", "modal");
            __builder.AddAttribute(44, "data-bs-target", "#EditProject");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                                                                                                                         (args) =>openEditDialog(Int16.Parse(@item.Id)) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<i class=\"material-icons\">edit</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                          ");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "type", "button");
            __builder.AddAttribute(50, "class", "btn btn-danger");
            __builder.AddAttribute(51, "id", 
#nullable restore
#line 55 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                                            item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(52, "data-bs-toggle", "modal");
            __builder.AddAttribute(53, "data-bs-target", "#DeleteProject");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                                                                                                                          (args) =>openDeletDialog(Int16.Parse(@item.Id)) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"material-icons\">delete</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
               }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
     if (EditDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.UserCrud.UpdateUser>(56);
            __builder.AddAttribute(57, "userID", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 66 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                               userId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 66 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                   onEditDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 67 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
     if (DeleteDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.UserCrud.DeleteUser>(59);
            __builder.AddAttribute(60, "DeveloperId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 71 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                    userId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(61, "Title", "Remove the User");
            __builder.AddAttribute(62, "Message", "Are you sure you want to remove the user");
            __builder.AddAttribute(63, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 71 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
                                                                                                                                       onDeleteDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 72 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n\r\n");
            __builder.AddMarkupContent(65, @"<style>
    .container{
        margin:0px;
        padding:0px;
    }
    .heading{
        width:100%;
        display: flex;
        justify-content: space-between;
        background-color: lightblue;
        padding:10px;
    }
    .table td{
        border-top:none;

    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 93 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UserView.razor"
       
    public int count = 0;
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public int userId { get; set; }
    List<Project> projectList = new List<Project>();
    List<Developer> userList = new List<Developer>();
    List<Company> listOfCompanies = new List<Company>();
    List<string> companyName = new List<string>();

    protected async override Task OnInitializedAsync()
    {
        listOfCompanies = companyService.listOfCompanies();
        projectList = projectService.listOfProjects();
        userList = userService.listOfUsers();

        foreach (var item in userList)
        {
            var companyLinqQuery = from value in listOfCompanies where value.Id == item.companyId select value.CompanyName.ToString();
            companyName.Add(companyLinqQuery.FirstOrDefault());  
        }
    }

    //update user
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
        userId = ButtonId;
        onEditDialogOpen();
    }

    //delete user
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
        userId = ButtonId;
        onDeleteDialogOpen();
    }

    public void addNewUser()
    {
        NavigationManager.NavigateTo("/user/add");
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

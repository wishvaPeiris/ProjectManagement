#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ef2c67f0048578a856e52e7085a2b4e19176acd"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementApp.Pages.CompanyCrud
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
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
           [Authorize(Policy = "AdminOnly")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/company")]
    public partial class CompanyView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "heading");
            __builder.AddMarkupContent(4, "<h3>Registered Companies in ProjectManager</h3>\r\n        ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-dark");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                   addNewCompany

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add companies");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "<br>\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "section1");
            __builder.AddMarkupContent(12, "<h3>List of Companies</h3>\r\n        ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, @"<thead><tr><th scope=""col"">No</th>
              <th scope=""col"">Company Name</th>
              <th scope=""col"">Created Date</th>
              <th scope=""col"">No.of Projects</th>
              <th scope=""col"">No.of Developers</th>
              <th>Manage Company</th></tr></thead>
          ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 31 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
               foreach (var item in listOfCompanies)
             {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "th");
            __builder.AddAttribute(19, "scope", "row");
#nullable restore
#line 35 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
__builder.AddContent(20, count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                      ");
            __builder.OpenElement(22, "td");
#nullable restore
#line 36 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
__builder.AddContent(23, item.CompanyName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                      ");
            __builder.OpenElement(25, "td");
#nullable restore
#line 37 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
__builder.AddContent(26, item.CreatedDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                      ");
            __builder.OpenElement(28, "td");
#nullable restore
#line 38 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
__builder.AddContent(29, item.companyProjects.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                      ");
            __builder.OpenElement(31, "td");
#nullable restore
#line 39 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
__builder.AddContent(32, item.companyDevs.Count());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                      ");
            __builder.OpenElement(34, "td");
            __builder.OpenElement(35, "button");
            __builder.AddAttribute(36, "type", "button");
            __builder.AddAttribute(37, "class", "btn btn-success");
            __builder.AddAttribute(38, "id", 
#nullable restore
#line 41 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                             item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(39, "data-bs-toggle", "modal");
            __builder.AddAttribute(40, "data-bs-target", "#EditCompany");
            __builder.AddAttribute(41, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                                                                                                         (args) =>openEditDialog(@item.Id,@item.CompanyName) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "<i class=\"material-icons\">edit</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                          ");
            __builder.OpenElement(44, "button");
            __builder.AddAttribute(45, "class", "btn btn-danger");
            __builder.AddAttribute(46, "id", 
#nullable restore
#line 42 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                              item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                                     (args) =>openDeletDialog(@item.Id) 

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(48, "<i class=\"material-icons\">delete</i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                     count++;
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
     if (EditDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.CompanyCrud.EditCompany>(49);
            __builder.AddAttribute(50, "IntialCompanyId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 52 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                       companyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "companyName", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 52 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                 intialCompName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(52, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 52 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                                             onEditDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 53 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
      if (DeleteDialogOpen)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<ProjectManagementApp.Pages.CompanyCrud.DeleteCompany>(53);
            __builder.AddAttribute(54, "Title", "Delete the Company");
            __builder.AddAttribute(55, "Message", "Are you sure you want to delete the following company");
            __builder.AddAttribute(56, "CompanyId", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 57 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                                                                                    companyId

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "OnClose", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 57 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
                                                                                                                                                           onDeleteDialogClose

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
#nullable restore
#line 58 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(59, "<style>\r\n    .container{\r\n        margin:0px;\r\n        padding:0px;\r\n    }\r\n    .heading{\r\n        width:100%;\r\n        display: flex;\r\n        justify-content: space-between;\r\n        background-color: lightblue;\r\n        padding:10px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\CompanyCrud\CompanyView.razor"
       
    public int count = 1;
    public bool EditDialogOpen { get; set; }
    public bool DeleteDialogOpen { get; set; }
    public int companyId { get; set; }
    public string intialCompName { get; set; }
    List<Project> projectList = new List<Project>();
    List<Developer> userList = new List<Developer>();
    List<Company> listOfCompanies = new List<Company>();

    protected async override Task OnInitializedAsync()
    {
        listOfCompanies = companyService.listOfCompanies();

        foreach (var item in listOfCompanies)
        {
            projectList = projectService.listOfProjectsToCompanyIdAsync(item.Id);
            userList = userService.listOfDevelopersInCompany(item.Id);
            item.companyProjects = projectList;
            item.companyDevs = userList;

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

    private void openEditDialog(int ButtonId,string compName)
    {
        intialCompName = compName;
        companyId = ButtonId;
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
        companyId = ButtonId;
        onDeleteDialogOpen();
    }

    private void addNewCompany()
    {
        NavigationManager.NavigateTo("/company/add");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService projectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService companyService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591

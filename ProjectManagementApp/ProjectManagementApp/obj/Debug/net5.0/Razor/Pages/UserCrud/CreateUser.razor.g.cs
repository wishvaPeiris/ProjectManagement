#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e238d3ec3f82da909ff3c6c12bc8368dbc2c080e"
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
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
using DataAccess;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/user/add")]
    public partial class CreateUser : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>CreateUser</h3>\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                    user

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                          HandleOnValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "class", "col-7 p-0");
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"user_name\">Username</label>\r\n        ");
                __builder2.OpenElement(13, "input");
                __builder2.AddAttribute(14, "id", "user_name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "placeholder", "alex@123");
                __builder2.AddAttribute(17, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                           userName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userName = __value, userName));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n    ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"user_email\">User Email</label>\r\n        ");
                __builder2.OpenElement(23, "input");
                __builder2.AddAttribute(24, "id", "user_email");
                __builder2.AddAttribute(25, "type", "email");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "placeholder", "alex123@gmail.com");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                                                  userEmail

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userEmail = __value, userEmail));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n    ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group");
                __builder2.AddMarkupContent(33, "<label for=\"user_contact\">User Contact</label>\r\n        ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "id", "user_contact");
                __builder2.AddAttribute(36, "class", "form-control");
                __builder2.AddAttribute(37, "placeholder", "0713830606");
                __builder2.AddAttribute(38, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                                userContact

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => userContact = __value, userContact));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n     ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "<label for=\"company_name\">Select the user type : </label>\r\n        ");
                __builder2.OpenElement(44, "select");
                __builder2.AddAttribute(45, "id", "userTypes");
                __builder2.AddAttribute(46, "name", "userTypes");
                __builder2.AddAttribute(47, "value", 
#nullable restore
#line 27 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                        selectedUserType

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                       onSelectedItemUser

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", "1");
                __builder2.AddContent(51, "Admin");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n            ");
                __builder2.OpenElement(53, "option");
                __builder2.AddAttribute(54, "value", "2");
                __builder2.AddContent(55, "Developer");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n     ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label for=\"company_name\">Select the company name</label>\r\n        ");
                __builder2.OpenElement(60, "select");
                __builder2.AddAttribute(61, "id", "companies");
                __builder2.AddAttribute(62, "disabled", 
#nullable restore
#line 34 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                          isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(63, "value", 
#nullable restore
#line 34 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                              selectedCompany

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(64, "name", "Companies");
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                                             onSelectedItemCompanies

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 35 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
             foreach (var item in listOfCompanies)
           {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(66, "option");
                __builder2.AddAttribute(67, "value", 
#nullable restore
#line 37 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                             item.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 37 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
__builder2.AddContent(68, item.CompanyName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 38 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
           }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n     ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "form-group");
                __builder2.AddMarkupContent(72, "<label for=\"project_name\">Select the project assigned</label>\r\n        ");
                __builder2.OpenElement(73, "select");
                __builder2.AddAttribute(74, "id", "projects");
                __builder2.AddAttribute(75, "disabled", 
#nullable restore
#line 43 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                         isDisabled

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(76, "value", 
#nullable restore
#line 43 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                             selectedProject

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(77, "name", "Projects");
                __builder2.AddAttribute(78, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                                                                                                           onSelectedItemProject

#line default
#line hidden
#nullable disable
                ));
#nullable restore
#line 44 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
             foreach (var item in listOfProjects)
           {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(79, "option");
                __builder2.AddAttribute(80, "value", 
#nullable restore
#line 46 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
                             item.projectId

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line 46 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
__builder2.AddContent(81, item.projectName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 47 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
           }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n    ");
                __builder2.AddMarkupContent(83, "<button class=\"btn btn-secondary\">Add the User</button>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 53 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\CreateUser.razor"
       
    public User user = new User();
    public Developer developer = new Developer();
    private string userName = "";
    private string userEmail = "";
    private string userContact = "";
    private string selectedUserType = "1";
    private string selectedCompany = "1";
    private string selectedProject = "1";
    private bool isDisabled = true;
    List<Company> listOfCompanies = new List<Company>();
    List<Project> listOfProjects = new List<Project>();

    protected async override Task OnInitializedAsync()
    {
        listOfCompanies = companyService.listOfCompanies();
        listOfProjects = projectService.listOfProjects();
    }

    public void onSelectedItemUser(ChangeEventArgs e)
    {
        selectedUserType = e.Value.ToString();
        if(Int16.Parse(selectedUserType) == 2)
        {
            isDisabled = false;
        }
        else
        {
            isDisabled = true;
        }
    }

    public void onSelectedItemCompanies(ChangeEventArgs e)
    {
        selectedCompany = e.Value.ToString();
    }

    public void onSelectedItemProject(ChangeEventArgs e)
    {
        selectedProject = e.Value.ToString();
    }

    public void HandleOnValidSubmit()
    {
         if(Int16.Parse(selectedUserType) == 2)
        {
            developer.UserName = userName;
            developer.Email = userEmail;
            developer.userContactNo = userContact;
            developer.companyId = Int16.Parse(selectedCompany);
            developer.projectId = Int16.Parse(selectedProject);
            userService.createDev(developer);
        }
        else
        {
            developer.UserName = userName;
            developer.Email = userEmail;
            user.userContactNo = userContact;
            userService.createAsync(user);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser userService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProjectService projectService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService companyService { get; set; }
    }
}
#pragma warning restore 1591

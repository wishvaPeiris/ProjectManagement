#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8741a54043efef3e211bcebeb14dd72a16b50391"
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
#line 1 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
using ProjectManagementApp.Services;

#line default
#line hidden
#nullable disable
    public partial class UpdateUser : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(12, "<h5 class=\"modal-title\" id=\"exampleModalLabel\">Update user</h5>\r\n        ");
            __builder.OpenElement(13, "button");
            __builder.AddAttribute(14, "type", "button");
            __builder.AddAttribute(15, "class", "btn-close");
            __builder.AddAttribute(16, "data-bs-dismiss", "modal");
            __builder.AddAttribute(17, "aria-label", "Close");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
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
            __builder.AddMarkupContent(25, "<label for=\"message-text\" class=\"col-form-label\">New Username:</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "text");
            __builder.AddAttribute(28, "class", "form-control");
            __builder.AddAttribute(29, "id", "recipient-name");
            __builder.AddAttribute(30, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
                                                                                        newUserName

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserName = __value, newUserName));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n          ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "mb-3");
            __builder.AddMarkupContent(35, "<label for=\"message-text\" class=\"col-form-label\">Updated Email:</label>\r\n            ");
            __builder.OpenElement(36, "input");
            __builder.AddAttribute(37, "type", "text");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "id", "recipient-name");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
                                                                                        newUserEmail

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserEmail = __value, newUserEmail));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n          ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "mb-3");
            __builder.AddMarkupContent(45, "<label for=\"message-text\" class=\"col-form-label\">New User Contact No:</label>\r\n            ");
            __builder.OpenElement(46, "input");
            __builder.AddAttribute(47, "type", "text");
            __builder.AddAttribute(48, "class", "form-control");
            __builder.AddAttribute(49, "id", "recipient-name");
            __builder.AddAttribute(50, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
                                                                                        newUserContactNo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(51, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newUserContactNo = __value, newUserContactNo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n      ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "modal-footer");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-secondary");
            __builder.AddAttribute(58, "data-bs-dismiss", "modal");
            __builder.AddAttribute(59, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 31 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
                                                                                           ModalCancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(60, "Close");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "type", "button");
            __builder.AddAttribute(64, "class", "btn btn-success");
            __builder.AddAttribute(65, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
                                                                 ModalOk

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(66, "Update User");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\UserCrud\UpdateUser.razor"
       
    public User user = new User();
    public Developer developer = new Developer();

    [Parameter]
    public string userID { get; set; }
    public string newUserName { get; set; }
    public string newUserEmail { get; set; }
    public string newUserContactNo { get; set; }

    [Parameter]
    public EventCallback<bool> OnClose { get; set; }

    protected async override Task OnInitializedAsync()
    {
        developer = UserService.GetDev(userID);
        newUserName = developer.UserName;
        newUserEmail = developer.Email;
        newUserContactNo = developer.userContactNo;
    }

    private Task ModalCancel()
    {
        return OnClose.InvokeAsync(false);
    }

    private Task ModalOk()
    {
        developer.UserName = newUserName;
        developer.Email = newUserEmail;
        developer.userContactNo = newUserContactNo;

        try
        {
            developer = UserService.UpateDev(developer);
            ToastService.ShowSuccess("Developer is updated successfully", "Success!");
        }
        catch (Exception)
        {
            ToastService.ShowError("Something went wrong when updating the developer", "Error");
        }

       return OnClose.InvokeAsync(true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IToastService ToastService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUser UserService { get; set; }
    }
}
#pragma warning restore 1591

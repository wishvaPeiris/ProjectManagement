#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca4dbeb3ad54e422ef82df5e383ec464a8ab6d73"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/project")]
    public partial class ProjectView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "heading");
            __builder.AddMarkupContent(4, "<h3>Projects added in the project Manager</h3>\r\n        ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-dark");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
                                                   addNewProject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Add Projects");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "<br>\r\n    ");
            __builder.AddMarkupContent(10, @"<div class=""section1""><h3>List of all the projects</h3>
        <table class=""table""><thead><tr><th scope=""col"">No</th>
              <th scope=""col"">Project Name</th>
              <th scope=""col"">Company Name</th>
              <th scope=""col"">No.of Developers</th></tr></thead>
          <tbody><tr><th scope=""row"">1</th>
              <td>Mark</td>
              <td>Otto</td>
              <td>mdo</td></tr>
            <tr><th scope=""row"">2</th>
              <td>Jacob</td>
              <td>Thornton</td>
              <td>fat</td></tr>
            <tr><th scope=""row"">3</th>
              <td>Larry</td>
              <td>the Bird</td>
              <td>twitter</td></tr></tbody></table></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n\r\n");
            __builder.AddMarkupContent(12, "<style>\r\n    .container{\r\n        margin:0px;\r\n        padding:0px;\r\n    }\r\n    .heading{\r\n        width:100%;\r\n        display: flex;\r\n        justify-content: space-between;\r\n        background-color: lightblue;\r\n        padding:10px;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectCrud\ProjectView.razor"
       
    private void addNewProject()
    {
        NavigationManager.NavigateTo("/project/add");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
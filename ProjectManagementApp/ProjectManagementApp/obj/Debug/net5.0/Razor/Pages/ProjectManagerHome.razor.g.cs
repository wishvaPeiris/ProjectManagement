#pragma checksum "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectManagerHome.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc17fd780e9c2868d5666fdf7eac8ea83240bba3"
// <auto-generated/>
#pragma warning disable 1591
namespace ProjectManagementApp.Pages
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
#line 3 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectManagerHome.razor"
using DataAccess.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User 01\Desktop\ProjectManagement\ProjectManagementApp\ProjectManagementApp\Pages\ProjectManagerHome.razor"
using Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/project_manager_home")]
    public partial class ProjectManagerHome : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Home</h3>\r\n\r\n\r\n");
            __builder.AddMarkupContent(1, @"<table class=""table""><thead><tr><th scope=""col"">#</th>
      <th scope=""col"">First</th>
      <th scope=""col"">Last</th>
      <th scope=""col"">Handle</th></tr></thead>
  <tbody><tr><th scope=""row"">1</th>
      <td>Mark</td>
      <td>Otto</td>
      <td>mdo</td></tr>
    <tr><th scope=""row"">2</th>
      <td>Jacob</td>
      <td>Thornton</td>
      <td>fat</td></tr>
    <tr><th scope=""row"">3</th>
      <td colspan=""2"">Larry the Bird</td>
      <td>twitter</td></tr></tbody></table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICompanyService CompanyService { get; set; }
    }
}
#pragma warning restore 1591

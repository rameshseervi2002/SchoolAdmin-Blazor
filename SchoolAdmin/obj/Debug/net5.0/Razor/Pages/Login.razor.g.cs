#pragma checksum "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0334c35a88434e1fb9eaa7b0686f3c4428f077d9"
// <auto-generated/>
#pragma warning disable 1591
namespace SchoolAdmin.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using SchoolAdmin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\_Imports.razor"
using SchoolAdmin.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Login.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Login.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Login.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 style=\"text-align: center;\">Login Page</h1>\r\n");
            __builder.AddMarkupContent(1, @"<div class=""container-fluid""><form><div class=""mb-3""><label for=""exampleInputEmail1"" class=""form-label"">Email address</label>
            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp""></div>
        <div class=""mb-3""><label for=""exampleInputPassword1"" class=""form-label"">Password</label>
            <input type=""password"" class=""form-control"" id=""exampleInputPassword1""></div>
        <button type=""submit"" class=""btn btn-primary"">Submit</button></form></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Imcrinox\Desktop\School Managament\SchoolAdmin\SchoolAdmin\Pages\Login.razor"
       
    public string userName = "admin@gmail.com";
    public string Password = "admin";
    public bool rememberMe = true;


    public void OnLogin( string name)
    {
        if(name == userName) {
            Console.WriteLine("Login Succesfully");
        }
        else
        {
            Console.WriteLine("Login Failed");
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591

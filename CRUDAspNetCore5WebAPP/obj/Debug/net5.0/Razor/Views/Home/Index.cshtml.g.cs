#pragma checksum "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b59e7e4e3389034ff1ed84372f099178c7d5a35d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\_ViewImports.cshtml"
using CRUDAspNetCore5WebAPP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\_ViewImports.cshtml"
using CRUDAspNetCore5WebAPP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b59e7e4e3389034ff1ed84372f099178c7d5a35d", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0799d62ce33c3811ed6bf41fe267936062b5c446", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CRUD_DAL.Entities.Manager>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NEPerson Core</a>.</p>\r\n");
#nullable restore
#line 9 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
      
        foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>");
#nullable restore
#line 12 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
           Write(item.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h1>");
#nullable restore
#line 13 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
           Write(item.UserEmail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h1>");
#nullable restore
#line 14 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
           Write(item.CreatedOn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            <h1>");
#nullable restore
#line 15 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
           Write(item.IsDeleted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n");
#nullable restore
#line 16 "C:\Users\husey\source\repos\CRUDAspNetCore5WebAPI\CRUDAspNetCore5WebAPP\Views\Home\Index.cshtml"
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CRUD_DAL.Entities.Manager>> Html { get; private set; }
    }
}
#pragma warning restore 1591
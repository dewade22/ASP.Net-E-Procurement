#pragma checksum "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "929bd8b504b720baf04bfb7c85ed383e7fb57834"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Balimoon_E_Procurement.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml", typeof(Balimoon_E_Procurement.Areas.Identity.Pages.Account.Manage.Areas_Identity_Pages_Account_Manage__Layout))]
namespace Balimoon_E_Procurement.Areas.Identity.Pages.Account.Manage
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\_ViewImports.cshtml"
using Balimoon_E_Procurement.Areas.Identity;

#line default
#line hidden
#line 3 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Balimoon_E_Procurement.Areas.Identity.Pages.Account;

#line default
#line hidden
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using Balimoon_E_Procurement.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"929bd8b504b720baf04bfb7c85ed383e7fb57834", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68ab5f152bd64542de998ab9e53f864969f1c12c", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16c8ef19e5c373dfcd723f5a5c3cc1e55c92edd3", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fd344241f6dcef5b741af2290bc81f783eb4e24", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 202, true);
            WriteLiteral("\r\n    <Center><h1>Manage your account</h1></Center>\r\n\r\n<div>\r\n    <center><h4>Change your account settings</h4></center>\r\n    <hr />\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-12\">\r\n            ");
            EndContext();
            BeginContext(257, 12, false);
#line 12 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(269, 40, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(327, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(334, 41, false);
#line 18 "D:\ASP.NET Program\03-07-2019\Balimoon E-Procurement\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(375, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

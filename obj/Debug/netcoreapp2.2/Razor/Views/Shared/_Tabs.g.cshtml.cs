#pragma checksum "D:\Project\Project_Email_MVC\Views\Shared\_Tabs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c68d7b574b37e711a810869f5918073bcc04e958"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Tabs), @"mvc.1.0.view", @"/Views/Shared/_Tabs.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Tabs.cshtml", typeof(AspNetCore.Views_Shared__Tabs))]
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
#line 1 "D:\Project\Project_Email_MVC\Views\_ViewImports.cshtml"
using Project_Email_MVC;

#line default
#line hidden
#line 2 "D:\Project\Project_Email_MVC\Views\_ViewImports.cshtml"
using Project_Email_MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68d7b574b37e711a810869f5918073bcc04e958", @"/Views/Shared/_Tabs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b91500b01dd805a70a517182ac746455c9ae02", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Tabs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 470, true);
            WriteLiteral(@"<ul class=""nav nav-pills flex-column"">
    <li class=""nav-item"">
        <a class=""nav-link"" href=""/Message/Compose"">Soạn thư</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" href=""/Message/Sent"">Đã gửi</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" href=""/Message/Received"">Đã nhận</a>
    </li>
    <li class=""nav-item"">
        <a class=""nav-link"" href=""/Message/RecycleBin"">Thùng rác</a>
    </li>
</ul>
        ");
            EndContext();
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
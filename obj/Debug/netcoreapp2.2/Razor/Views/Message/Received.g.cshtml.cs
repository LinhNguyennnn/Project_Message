#pragma checksum "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03ad586c4945e75d45412458e8bfbf24fbc3bac4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_Received), @"mvc.1.0.view", @"/Views/Message/Received.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Message/Received.cshtml", typeof(AspNetCore.Views_Message_Received))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03ad586c4945e75d45412458e8bfbf24fbc3bac4", @"/Views/Message/Received.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36b91500b01dd805a70a517182ac746455c9ae02", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_Received : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/_Tabs.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
  
ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(41, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 6 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
      Html.RenderPartial("_HeaderNavBar");

#line default
#line hidden
            BeginContext(115, 64, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-3\">\r\n            ");
            EndContext();
            BeginContext(179, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "03ad586c4945e75d45412458e8bfbf24fbc3bac43953", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(224, 133, true);
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-9\">\r\n            <div class=\"container\"><br>\r\n                    <ul class=\"list-group\">\r\n");
            EndContext();
#line 14 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                         if(ViewBag.ListMessReceive != null)
                        {
                        

#line default
#line hidden
#line 16 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                         foreach (var item in ViewBag.ListMessReceive)
                        {

#line default
#line hidden
            BeginContext(545, 410, true);
            WriteLiteral(@"                                <li class=""list-group-item"">
                                    <div class=""container"">
                                        <div class=""row"">
                                            <div class=""col-4 text-truncate"">
                                                <b class=""text-dark d-inline-block"">
                                                    Người gửi: ");
            EndContext();
            BeginContext(956, 26, false);
#line 23 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                                                          Write(item.Message.User.Username);

#line default
#line hidden
            EndContext();
            BeginContext(982, 457, true);
            WriteLiteral(@"
                                                </b>
                                            </div>
                                            <div class=""col-7 contentt"">
                                                <div class=""row"">
                                                    <div class=""col-6 text-truncate"">
                                                        <b>
                                                            ");
            EndContext();
            BeginContext(1440, 18, false);
#line 30 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                                                       Write(item.Message.Title);

#line default
#line hidden
            EndContext();
            BeginContext(1458, 337, true);
            WriteLiteral(@"
                                                        </b>
                                                    </div>
                                                    <div class=""col-6 text-truncate"">
                                                        <span>
                                                            - ");
            EndContext();
            BeginContext(1796, 20, false);
#line 35 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                                                         Write(item.Message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1816, 378, true);
            WriteLiteral(@"
                                                        </span>
                                                    </div>
                                                </div>
                                            </div>
                                            <div class=""col-1"">
                                                <button class=""btn btn-danger""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2194, "\"", 2281, 5);
            WriteAttributeValue("", 2204, "window.location.href", 2204, 20, true);
            WriteAttributeValue(" ", 2224, "=", 2225, 2, true);
            WriteAttributeValue(" ", 2226, "\'/Message/RemoveByReceived?MessageId=", 2227, 38, true);
#line 41 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
WriteAttributeValue("", 2264, item.Message.Id, 2264, 16, false);

#line default
#line hidden
            WriteAttributeValue("", 2280, "\'", 2280, 1, true);
            EndWriteAttribute();
            BeginContext(2282, 347, true);
            WriteLiteral(@">
                                                    <i class=""fa fa-trash-o"" aria-hidden=""true""></i>
                                                </button>
                                            </div>
                                        </div>
                                    </div>
                                </li>
");
            EndContext();
#line 48 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                        }

#line default
#line hidden
#line 48 "D:\Project\Project_Email_MVC\Views\Message\Received.cshtml"
                         
                        }

#line default
#line hidden
            BeginContext(2683, 81, true);
            WriteLiteral("                    </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

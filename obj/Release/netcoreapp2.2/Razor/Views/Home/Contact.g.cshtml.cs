#pragma checksum "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34712916fbcba2ff878a0afcb06789f2922039f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Laptop\Documents\UFPCore\Views\_ViewImports.cshtml"
using UFPCore;

#line default
#line hidden
#line 2 "C:\Users\Laptop\Documents\UFPCore\Views\_ViewImports.cshtml"
using UFPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34712916fbcba2ff878a0afcb06789f2922039f5", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c94c6627525b60acdf0b00af8c4a7d2a416e48", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UFPCore.Models.ContactForm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(34, 106, true);
            WriteLiteral("<h2>Contact</h2>\nIf you have any questions, please complete the form below and we will be in touch ASAP.\n\n");
            EndContext();
#line 5 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
 using (Html.BeginForm("Contact", "Home", FormMethod.Post, new { @class = "form-horizontal", role = "form" }))
{

#line default
#line hidden
            BeginContext(254, 23, false);
#line 7 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(278, 7, true);
            WriteLiteral("<hr />\n");
            EndContext();
            BeginContext(286, 58, false);
#line 9 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(345, 29, true);
            WriteLiteral("<div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(375, 69, false);
#line 11 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
Write(Html.LabelFor(m => m.Name, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(444, 37, true);
            WriteLiteral("\n    <div class=\"col-md-10\">\n        ");
            EndContext();
            BeginContext(482, 61, false);
#line 13 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
   Write(Html.TextBoxFor(m => m.Name, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(543, 48, true);
            WriteLiteral("\n    </div>\n</div>\n<div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(592, 70, false);
#line 17 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(662, 37, true);
            WriteLiteral("\n    <div class=\"col-md-10\">\n        ");
            EndContext();
            BeginContext(700, 62, false);
#line 19 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
   Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(762, 48, true);
            WriteLiteral("\n    </div>\n</div>\n<div class=\"form-group\">\n    ");
            EndContext();
            BeginContext(811, 72, false);
#line 23 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
Write(Html.LabelFor(m => m.Message, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
            EndContext();
            BeginContext(883, 37, true);
            WriteLiteral("\n    <div class=\"col-md-10\">\n        ");
            EndContext();
            BeginContext(921, 92, false);
#line 25 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
   Write(Html.TextAreaFor(m => m.Message, new { @class = "form-control", style = "height: 150px;" } ));

#line default
#line hidden
            EndContext();
            BeginContext(1013, 172, true);
            WriteLiteral("\n    </div>\n</div>\n<div class=\"form-group\">\n    <div class=\"col-md-offset-2 col-md-10\">\n        <button type=\"submit\" class=\"btn btn-light\">Send</button>\n    </div>\n</div>\n");
            EndContext();
#line 33 "C:\Users\Laptop\Documents\UFPCore\Views\Home\Contact.cshtml"
}

#line default
#line hidden
            BeginContext(1187, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1206, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(1211, 98, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34712916fbcba2ff878a0afcb06789f2922039f57848", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1309, 55, true);
                WriteLiteral("\n    <!-- at Scripts.Render(\"~/bundles/jqueryval\") -->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UFPCore.Models.ContactForm> Html { get; private set; }
    }
}
#pragma warning restore 1591
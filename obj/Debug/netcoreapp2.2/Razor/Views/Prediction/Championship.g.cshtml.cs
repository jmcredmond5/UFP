#pragma checksum "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e881c148043cbb769446e18685681d4a2d2d92c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Prediction_Championship), @"mvc.1.0.view", @"/Views/Prediction/Championship.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Prediction/Championship.cshtml", typeof(AspNetCore.Views_Prediction_Championship))]
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
#line 2 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
using UFPCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e881c148043cbb769446e18685681d4a2d2d92c", @"/Views/Prediction/Championship.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c94c6627525b60acdf0b00af8c4a7d2a416e48", @"/Views/_ViewImports.cshtml")]
    public class Views_Prediction_Championship : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UFPCore.Models.Predictions.ChampionshipViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_NavLinks", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
  
    ViewBag.Title = "Championship Predictions";

#line default
#line hidden
            BeginContext(136, 47, true);
            WriteLiteral("\r\n<h2>Predictions</h2>\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(183, 26, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7e881c148043cbb769446e18685681d4a2d2d92c3763", async() => {
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
            BeginContext(209, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 11 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
 using (Html.BeginForm("Championship", "Prediction", FormMethod.Post, new { @class = "form-horizontal" }))
{
    

#line default
#line hidden
            BeginContext(335, 23, false);
#line 13 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(360, 313, true);
            WriteLiteral(@"    <h4>Predict the answers to these questions about the Championship:</h4>
    <div class=""container"">
        <div class=""row"">
            <div class=""col-sm-12"">
                <p>Who will win the Championship:</p>
                <div class=""form-group form-group-small-b-margin"">
                    ");
            EndContext();
            BeginContext(674, 164, false);
#line 20 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.Title, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(838, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(861, 88, false);
#line 21 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.Title, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(949, 165, true);
            WriteLiteral("\r\n                </div>\r\n                <p>Who will be the runner up:</p>\r\n                <div class=\"form-group form-group-small-b-margin\">\r\n                    ");
            EndContext();
            BeginContext(1115, 167, false);
#line 25 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.RunnerUp, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1305, 91, false);
#line 26 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.RunnerUp, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1396, 262, true);
            WriteLiteral(@"
                </div>
                <p>Who will be in the playoffs:</p>
                <div class=""row"">
                    <div class=""col-sm-6"">
                        <div class=""form-group form-group-small-b-margin"">
                            ");
            EndContext();
            BeginContext(1659, 167, false);
#line 32 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.DropDownListFor(m => m.Championship.Playoff1, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1857, 91, false);
#line 33 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Championship.Playoff1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1948, 138, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group form-group-small-b-margin\">\r\n                            ");
            EndContext();
            BeginContext(2087, 167, false);
#line 36 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.DropDownListFor(m => m.Championship.Playoff3, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(2254, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2285, 91, false);
#line 37 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Championship.Playoff3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2376, 210, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-sm-6\">\r\n                        <div class=\"form-group form-group-small-b-margin\">\r\n                            ");
            EndContext();
            BeginContext(2587, 167, false);
#line 42 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.DropDownListFor(m => m.Championship.Playoff2, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(2754, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(2785, 91, false);
#line 43 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Championship.Playoff2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2876, 138, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group form-group-small-b-margin\">\r\n                            ");
            EndContext();
            BeginContext(3015, 167, false);
#line 46 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.DropDownListFor(m => m.Championship.Playoff4, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(3182, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(3213, 91, false);
#line 47 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                       Write(Html.ValidationMessageFor(m => m.Championship.Playoff4, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3304, 225, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n                <p>Who will win the playoffs:</p>\r\n                <div class=\"form-group form-group-small-b-margin\">\r\n                    ");
            EndContext();
            BeginContext(3530, 172, false);
#line 53 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.PlayoffWinner, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(3702, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3725, 96, false);
#line 54 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.PlayoffWinner, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3821, 161, true);
            WriteLiteral("\r\n                </div>\r\n                <p>Who will be relegated:</p>\r\n                <div class=\"form-group form-group-small-b-margin\">\r\n                    ");
            EndContext();
            BeginContext(3983, 170, false);
#line 58 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.Relegation1, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(4153, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4176, 94, false);
#line 59 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.Relegation1, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4270, 114, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group form-group-small-b-margin\">\r\n                    ");
            EndContext();
            BeginContext(4385, 170, false);
#line 62 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.Relegation2, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(4555, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4578, 94, false);
#line 63 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.Relegation2, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4672, 114, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group form-group-small-b-margin\">\r\n                    ");
            EndContext();
            BeginContext(4787, 170, false);
#line 66 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.DropDownListFor(m => m.Championship.Relegation3, Html.GetEnumSelectList(typeof(ChampionshipTeamsEnum)), "select a team", new { @class = "form-control margin-left" }));

#line default
#line hidden
            EndContext();
            BeginContext(4957, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(4980, 94, false);
#line 67 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
               Write(Html.ValidationMessageFor(m => m.Championship.Relegation3, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(5074, 44, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                ");
            EndContext();
            BeginContext(5119, 38, false);
#line 70 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
           Write(Html.HiddenFor(m => m.Championship.Id));

#line default
#line hidden
            EndContext();
            BeginContext(5157, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5176, 40, false);
#line 71 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
           Write(Html.HiddenFor(m => m.Championship.User));

#line default
#line hidden
            EndContext();
            BeginContext(5216, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5235, 39, false);
#line 72 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
           Write(Html.HiddenFor(m => m.Completions.User));

#line default
#line hidden
            EndContext();
            BeginContext(5274, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(5293, 37, false);
#line 73 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
           Write(Html.HiddenFor(m => m.Completions.Id));

#line default
#line hidden
            EndContext();
            BeginContext(5330, 74, true);
            WriteLiteral("\r\n                <p>When you have completed this section, tick this box: ");
            EndContext();
            BeginContext(5405, 39, false);
#line 74 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
                                                                   Write(Html.CheckBoxFor(m => m.ChampCompleted));

#line default
#line hidden
            EndContext();
            BeginContext(5444, 396, true);
            WriteLiteral(@"</p> 
                <p>You can still come back and edit the predictions later.</p>
                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <button type=""submit"" class=""btn btn-light"">Save and continue</button>
                    </div>
                </div>
            </div>
        </div>
        
    </div>
");
            EndContext();
#line 85 "C:\Users\Laptop\Documents\UFPCore\Views\Prediction\Championship.cshtml"
}

#line default
#line hidden
            BeginContext(5843, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UFPCore.Models.Predictions.ChampionshipViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
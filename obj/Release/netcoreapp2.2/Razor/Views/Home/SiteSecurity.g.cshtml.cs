#pragma checksum "C:\Users\Laptop\Documents\UFPCore\Views\Home\SiteSecurity.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18dea05224bbd311fb452c22a20149bd95400882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SiteSecurity), @"mvc.1.0.view", @"/Views/Home/SiteSecurity.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/SiteSecurity.cshtml", typeof(AspNetCore.Views_Home_SiteSecurity))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18dea05224bbd311fb452c22a20149bd95400882", @"/Views/Home/SiteSecurity.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30c94c6627525b60acdf0b00af8c4a7d2a416e48", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SiteSecurity : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GDPR", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Laptop\Documents\UFPCore\Views\Home\SiteSecurity.cshtml"
  
    ViewData["Title"] = "Site Security";

#line default
#line hidden
            BeginContext(49, 4, true);
            WriteLiteral("<h1>");
            EndContext();
            BeginContext(54, 17, false);
#line 4 "C:\Users\Laptop\Documents\UFPCore\Views\Home\SiteSecurity.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(71, 18, true);
            WriteLiteral("</h1>\r\n\r\n<p>Click ");
            EndContext();
            BeginContext(89, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "18dea05224bbd311fb452c22a20149bd954008824521", async() => {
                BeginContext(144, 4, true);
                WriteLiteral("here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(152, 5189, true);
            WriteLiteral(@" to see our GDPR policy.</p>
<p>Please scroll down to view our Cookie Policy.</p>
<p>The UFP website is a certified SSL site with HTTPS.</p>

<h4>What is HTTPS?</h4>
<p>Hyper Text Transfer Protocol Secure (HTTPS) is the secure protocol through which your browser communicates with sites.</p>
<p>When using HTTP sites, any data that is transferred can potentially be accessed or manipulated by attackers. However, when using HTTPS sites, data is encrypted and authenticated and therefore secured. As a result, this site's visitors' information is encrypted, and therefore more secure.</p>
<p>Many users are more comfortable making purchases and sharing their personal information online when visiting secured sites. As your UFP entry is completed and paid for on the website, this makes your transaction more secure.</p>
<p>To check whether a site you are visiting is HTTPS, check the URL bar to see if the website begins https://, as opposed to the comparatively insecure http://. Google Chrome displays warnings any");
            WriteLiteral(@"time that a user visits a site that is not using HTTPS.</p>
​

<h4>What is SSL?</h4>
<p>A Secure Sockets Layer, or SSL certificate, allows visitors to view The UFP's site over an HTTPS connection.  It secures the connection between your browser and the site.</p> 
<p>Please note:</p>
<p>Older browsers do not support the high security standards required by the SSL certificate on this site. Please ensure your browser is up-to-date when visiting The UFP website to ensure maximum internet security.</p>
<p>For more information on SSL Certification, please click here.</p>


<h3>Cookie Policy for The Unique Football Predictor</h3>
<p>This is the Cookie Policy for The UFP, accessible on www.theufp.co.uk.</p>

<h4>What are cookies?</h4>
<p>As is common practice with almost all professional websites, this site uses cookies, which are tiny files that are downloaded to your computer to improve your experience. This section of our Security page describes what information the cookies gather, how we use it and ");
            WriteLiteral(@"why we sometimes need to store these cookies. We will also share how you can prevent these cookies from being stored; however, this may downgrade or 'break' certain elements of the site's functionality.</p>

<h4>How we use cookies</h4>
<p>We use cookies for a variety of reasons detailed below. Unfortunately, in most cases, there are no industry standard options for disabling cookies without completely disabling the functionality and features they add to this site. It is recommended that you leave on all cookies if you are not sure whether you need them or not, in case they are used to provide a service that you use.</p>
​
<h4>Disabling cookies</h4>
<p>You can prevent the setting of cookies by adjusting the settings on your browser (see your browser 'Help' for information on how to do this). Be aware that disabling cookies will affect the functionality of this and many other websites that you visit. Therefore it is recommended that you do not disable cookies.</p>
<p>The cookies we set
    <ul>
       ");
            WriteLiteral(@" <li>Site preferences cookies</li>
    </ul>
In order to remember your preferences on the site - such as pages you often visit or information you input - we need to set cookies so that this information can be called whenever you interact with a page which is affected by your preferences.
</p>​

<h4>Third party cookies</h4>
<p>In some special cases we also use cookies provided by trusted third parties:</p>
<ul>
    <li>This site uses Google Analytics which is one of the most widespread and trusted analytics solution on the web for helping us to understand how you use the site and ways that we can improve your experience. These cookies may track things such as how long you spend on the site and the pages that you visit so we can continue to produce engaging content. For more information on Google Analytics cookies, see the official Google Analytics page.</li>
    <li>From time to time we test new features and make subtle changes to the way that the site is delivered. When we are still testing new featu");
            WriteLiteral(@"res, these cookies may be used to ensure that you receive a consistent experience whilst on the site whilst ensuring we understand which optimisations our users appreciate the most.</li>
    <li>We also use social media buttons and/or plugins on this site that allow you to connect with your social network in various ways. For these to work, Facebook and Instagram will set cookies through our site which may be used to enhance your profile on their site or contribute to the data they hold for various purposes outlined in their respective privacy policies. The UFP does not have access to any of your social networking as a direct result of our use of cookies.</li>
</ul>
​
<h3>More information</h3>
<p>Hopefully that has clarified things for you and, as was previously mentioned, if there is something that you aren't sure whether you need or not, it's usually safer to leave cookies enabled in case it does interact with one of the features you use on our site.
However, if you are still looking for more informat");
            WriteLiteral("ion, then you can contact us by email: [email address here].</p>\r\n​\r\n");
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
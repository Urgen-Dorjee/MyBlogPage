#pragma checksum "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f3d22606868a87dc21ec519057b696845717a65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BlogWeb.UI.Views.Post.Views_Post_GetPost), @"mvc.1.0.view", @"/Views/Post/GetPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/GetPost.cshtml", typeof(BlogWeb.UI.Views.Post.Views_Post_GetPost))]
namespace BlogWeb.UI.Views.Post
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\_ViewImports.cshtml"
using Application.Queries.Models;

#line default
#line hidden
#line 2 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f3d22606868a87dc21ec519057b696845717a65", @"/Views/Post/GetPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c28f8ea54e4ad5f915ab4fd9e3767a57a44b4f89", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_GetPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
   
   ViewData["Title"] = "Blog Details";

#line default
#line hidden
            BeginContext(68, 78, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h3 class=\"post-detail-header\">\r\n        <span>");
            EndContext();
            BeginContext(147, 11, false);
#line 10 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
         Write(Model.Topic);

#line default
#line hidden
            EndContext();
            BeginContext(158, 83, true);
            WriteLiteral("</span>\r\n    </h3>\r\n    <div class=\"post-authorname\">\r\n        <span>Published By: ");
            EndContext();
            BeginContext(242, 16, false);
#line 13 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
                       Write(Model.AuthorName);

#line default
#line hidden
            EndContext();
            BeginContext(258, 58, true);
            WriteLiteral("</span>\r\n        <span class=\"timeStampValue\" data-value=\"");
            EndContext();
            BeginContext(317, 15, false);
#line 14 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
                                            Write(Model.Published);

#line default
#line hidden
            EndContext();
            BeginContext(332, 18, true);
            WriteLiteral("\">Published Date: ");
            EndContext();
            BeginContext(351, 15, false);
#line 14 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
                                                                              Write(Model.Published);

#line default
#line hidden
            EndContext();
            BeginContext(366, 113, true);
            WriteLiteral("</span>\r\n    </div>    \r\n\r\n    <markdown markdown=\"Content\" />       \r\n\r\n    <div class=\"main-content\">\r\n        ");
            EndContext();
            BeginContext(480, 13, false);
#line 20 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
   Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(493, 24, true);
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostDto> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7efb22324d8ea840f442a1eebe64887f835349e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_GetPost), @"mvc.1.0.view", @"/Views/Post/GetPost.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/GetPost.cshtml", typeof(AspNetCore.Views_Post_GetPost))]
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
#line 1 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\_ViewImports.cshtml"
using BlogWeb.UI.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\_ViewImports.cshtml"
using Application.Queries.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7efb22324d8ea840f442a1eebe64887f835349e7", @"/Views/Post/GetPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d7bbfce0901e7b15db0c6d4249df86484a2718c", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(70, 77, true);
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n\r\n    <div class=\"post-detail-header\">\r\n        ");
            EndContext();
            BeginContext(148, 11, false);
#line 13 "C:\Users\urgen\Desktop\Technology\TechBloggingWebSite\BlogWeb.UI\Views\Post\GetPost.cshtml"
   Write(Model.Topic);

#line default
#line hidden
            EndContext();
            BeginContext(159, 34, true);
            WriteLiteral("\r\n    </div>\r\n    \r\n    \r\n</div>\r\n");
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

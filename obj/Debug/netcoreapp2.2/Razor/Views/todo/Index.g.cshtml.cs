#pragma checksum "/home/curso/Documentos/clase2/Views/todo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "047d7f14032a5d0da17c118682b3da6c77aca53d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_todo_Index), @"mvc.1.0.view", @"/Views/todo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/todo/Index.cshtml", typeof(AspNetCore.Views_todo_Index))]
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
#line 1 "/home/curso/Documentos/clase2/Views/_ViewImports.cshtml"
using clase2;

#line default
#line hidden
#line 2 "/home/curso/Documentos/clase2/Views/_ViewImports.cshtml"
using clase2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"047d7f14032a5d0da17c118682b3da6c77aca53d", @"/Views/todo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ff3d3eb5472d69b39c43614d7309f1e38840fbf", @"/Views/_ViewImports.cshtml")]
    public class Views_todo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<todoViewmodels>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
  
  ViewData["Title"] = "Manage your todo list";

#line default
#line hidden
            BeginContext(74, 73, true);
            WriteLiteral("<div class=\"panel panel-default todo-panel\">\n\t<div class=\"panel-heading\">");
            EndContext();
            BeginContext(148, 17, false);
#line 6 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(165, 146, true);
            WriteLiteral("</div>\n\t\t<table class=\"table table-hover\">\n\t\t\t<thead>\n\t\t\t\t<tr>\n\t\t\t\t\t<td>&#x2714;</td>\n\t\t\t\t\t<td>Item</td>\n\t\t\t\t\t<td>Due</td>\n\t\t\t\t</tr>\n\t\t  </thead>\n");
            EndContext();
#line 15 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
           foreach (var item in Model.iten)
		  {

#line default
#line hidden
            BeginContext(355, 86, true);
            WriteLiteral("\t\t\t<tr>\n\t\t\t\t<td>\n\t\t\t\t\t<input type=\"checkbox\" class=\"done-checkbox\">\n\t\t\t\t</td>\n\t\t\t\t<td>");
            EndContext();
            BeginContext(442, 10, false);
#line 21 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
               Write(item.Title);

#line default
#line hidden
            EndContext();
            BeginContext(452, 14, true);
            WriteLiteral("</td>\n\t\t\t\t<td>");
            EndContext();
            BeginContext(467, 10, false);
#line 22 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
               Write(item.DueAt);

#line default
#line hidden
            EndContext();
            BeginContext(477, 15, true);
            WriteLiteral("</td>\n\t\t\t</tr>\n");
            EndContext();
#line 24 "/home/curso/Documentos/clase2/Views/todo/Index.cshtml"
		  }

#line default
#line hidden
            BeginContext(498, 101, true);
            WriteLiteral("\t  </table>\n  <div class=\"panel-footer add-item-form\">\n  <!-- TODO: Add item form -->\n  </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<todoViewmodels> Html { get; private set; }
    }
}
#pragma warning restore 1591

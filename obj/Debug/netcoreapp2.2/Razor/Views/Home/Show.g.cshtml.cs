#pragma checksum "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d1b02f2b47749a75de9dd7eb902c001e22ec45a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Show), @"mvc.1.0.view", @"/Views/Home/Show.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Show.cshtml", typeof(AspNetCore.Views_Home_Show))]
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
#line 1 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious;

#line default
#line hidden
#line 2 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\_ViewImports.cshtml"
using CRUDelicious.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1b02f2b47749a75de9dd7eb902c001e22ec45a", @"/Views/Home/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"815eae4269ab1eac71e8261ccfa9294c33285639", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
  
    ViewData["Title"] = "Selected Dish";

#line default
#line hidden
            BeginContext(64, 50, true);
            WriteLiteral("<a href=\"/\" class=\"btn btn-success\">Home</a>\r\n<h1>");
            EndContext();
            BeginContext(115, 10, false);
#line 7 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(125, 11, true);
            WriteLiteral("</h1>\r\n<h3>");
            EndContext();
            BeginContext(137, 10, false);
#line 8 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
Write(Model.Chef);

#line default
#line hidden
            EndContext();
            BeginContext(147, 40, true);
            WriteLiteral("</h3>\r\n<p>_____________________</p>\r\n<p>");
            EndContext();
            BeginContext(188, 17, false);
#line 10 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(205, 19, true);
            WriteLiteral("</p>\r\n<p>Calories: ");
            EndContext();
            BeginContext(225, 14, false);
#line 11 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
        Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(239, 20, true);
            WriteLiteral("</p>\r\n<p>Tastiness: ");
            EndContext();
            BeginContext(260, 15, false);
#line 12 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
         Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(275, 10, true);
            WriteLiteral("</p>\r\n\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 285, "\"", 310, 2);
            WriteAttributeValue("", 292, "edit/", 292, 5, true);
#line 14 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
WriteAttributeValue("", 297, Model.DishId, 297, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(311, 37, true);
            WriteLiteral(" class=\"btn btn-warning\">Edit</a>\r\n<a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 348, "\"", 375, 2);
            WriteAttributeValue("", 355, "delete/", 355, 7, true);
#line 15 "C:\Users\Bill\Documents\CodingFiles\CodingDojo\csharp\entity\CRUDelicious\Views\Home\Show.cshtml"
WriteAttributeValue("", 362, Model.DishId, 362, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(376, 38, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6da013e55c2aba554255b0e6a8b7ae8309794660"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6da013e55c2aba554255b0e6a8b7ae8309794660", @"/Views/Courses/Index.cshtml")]
    #nullable restore
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Task1.Model.Course>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Topic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseGrade));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 770, "\"", 793, 1);
#nullable restore
#line 34 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
WriteAttributeValue("", 785, item.Id, 785, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 846, "\"", 869, 1);
#nullable restore
#line 35 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
WriteAttributeValue("", 861, item.Id, 861, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 924, "\"", 947, 1);
#nullable restore
#line 36 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
WriteAttributeValue("", 939, item.Id, 939, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 39 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Courses\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Task1.Model.Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Students\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34052041df2a22e7b3b4302734ca9baf31e0729a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Students_Create), @"mvc.1.0.view", @"/Views/Students/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34052041df2a22e7b3b4302734ca9baf31e0729a", @"/Views/Students/Create.cshtml")]
    #nullable restore
    public class Views_Students_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Task1.Model.Student>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Students\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Student</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Email"" class=""control-label""></label>
                <input asp-for=""Email"" class=""form-control"" />
                <span asp-validation-for=""Email"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PhoneNum"" class=""control-label""></label>
                <input asp-for=""PhoneNum"" class=""form-control"" />
                <span asp-validation-for=""PhoneNum"" class=""text-danger""></span>
            </d");
            WriteLiteral(@"iv>
            <div class=""form-group"">
                <label asp-for=""Birthdate"" class=""control-label""></label>
                <input asp-for=""Birthdate"" class=""form-control"" />
                <span asp-validation-for=""Birthdate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Gender"" class=""control-label""></label>
                <select asp-for=""Gender"" class=""form-control""></select>
                <span asp-validation-for=""Gender"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 52 "E:\ITI\ITI-9-months-scholarship\MVC\Day8\Task1\Views\Students\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Task1.Model.Student> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
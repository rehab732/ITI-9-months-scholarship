#pragma checksum "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8d89b4e8195bbf7ff39b07d24e04aa28b9be2862"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_SelectCarByID), @"mvc.1.0.view", @"/Views/Car/SelectCarByID.cshtml")]
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
#nullable restore
#line 1 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
using Day7.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d89b4e8195bbf7ff39b07d24e04aa28b9be2862", @"/Views/Car/SelectCarByID.cshtml")]
    #nullable restore
    public class Views_Car_SelectCarByID : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
  
    ViewBag.Title = "SelectCarByID";
    Car select = ViewBag.selectedcar;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"color:red;font:bold\">Select Car By Number</h1>\r\n<h3>Car Number : ");
#nullable restore
#line 8 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
            Write(select.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Car Model : ");
#nullable restore
#line 9 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
           Write(select.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Car Color : ");
#nullable restore
#line 10 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
           Write(select.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<h3>Car Manfacture : ");
#nullable restore
#line 11 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\SelectCarByID.cshtml"
                Write(select.Manfacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h4 style=\"color:red;font:bold\"><a href=\"/Car/GetAllCars\" /> Back to Cars Table</h4>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

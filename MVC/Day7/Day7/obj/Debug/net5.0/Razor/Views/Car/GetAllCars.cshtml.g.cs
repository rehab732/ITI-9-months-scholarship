#pragma checksum "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd78b36b2e33f3438a523a8f163212e389c8692b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Car_GetAllCars), @"mvc.1.0.view", @"/Views/Car/GetAllCars.cshtml")]
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
#line 1 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
using Day7.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd78b36b2e33f3438a523a8f163212e389c8692b", @"/Views/Car/GetAllCars.cshtml")]
    #nullable restore
    public class Views_Car_GetAllCars : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
  
    ViewBag.Title = "GetAllCars";
    List<Car> mycarlist = ViewBag.cars;//keda esta2belt eldata elly gaya on el controller



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 style=""color:red;font:bold"">Get All Cars</h1>
<div>
    <table style=""border-collapse:collapse;margin-bottom:1rem;background-color:antiquewhite;color:black"">
        <tr>
            <th style=""border:1px solid red; ""> Car Num  </th>
            <th style=""border:1px solid red; ""> Car Model  </th>
            <th style=""border:1px solid red; ""> Car Manfacture  </th>
            <th style=""border:1px solid red; ""> Car Color  </th>
            <th style=""border:1px solid red; "">Select  </th>
            <th style=""border:1px solid red; "">Delete  </th>
            <th style=""border:1px solid red; "">Edit  </th>


        </tr>
");
#nullable restore
#line 23 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
         foreach (var item in mycarlist)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"border:1px solid black; \">\r\n                <td style=\"border:1px solid black; \">");
#nullable restore
#line 26 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
                                                Write(item.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"border:1px solid black; \">");
#nullable restore
#line 27 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
                                                Write(item.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"border:1px solid black; \">");
#nullable restore
#line 28 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
                                                Write(item.Manfacture);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td style=\"border:1px solid black; \">");
#nullable restore
#line 29 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
                                                Write(item.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td style=\"border:1px solid black; \"><a");
            BeginWriteAttribute("href", " href=\"", 1256, "\"", 1291, 2);
            WriteAttributeValue("", 1263, "/Car/SelectCarByID/", 1263, 19, true);
#nullable restore
#line 31 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 1282, item.Num, 1282, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> Select Car  </td>\r\n                <td style=\"border:1px solid black; \"><a");
            BeginWriteAttribute("href", " href=\"", 1370, "\"", 1405, 2);
            WriteAttributeValue("", 1377, "/Car/DeleteCarByID/", 1377, 19, true);
#nullable restore
#line 32 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 1396, item.Num, 1396, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> Delete Car  </td>\r\n                <td style=\"border:1px solid black; \"><a");
            BeginWriteAttribute("href", " href=\"", 1484, "\"", 1517, 2);
            WriteAttributeValue("", 1491, "/Car/EditCarByID/", 1491, 17, true);
#nullable restore
#line 33 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
WriteAttributeValue("", 1508, item.Num, 1508, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /> Edit Car  </td>\r\n\r\n            </tr>\r\n");
#nullable restore
#line 36 "E:\ITI\ITI-9-months-scholarship\MVC\Day7\Day7\Views\Car\GetAllCars.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n    <button onclick=\"location.href=\'/Car/CreateNewCar\'\"> Create New Car</button>\r\n\r\n\r\n</div>");
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

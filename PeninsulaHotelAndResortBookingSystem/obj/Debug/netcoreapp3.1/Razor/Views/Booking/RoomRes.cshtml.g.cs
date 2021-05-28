#pragma checksum "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18b9a11f0eb5490c8c2ed77015b5969450a33d00"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Booking_RoomRes), @"mvc.1.0.view", @"/Views/Booking/RoomRes.cshtml")]
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
#line 1 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\_ViewImports.cshtml"
using PeninsulaHotelAndResortBookingSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\_ViewImports.cshtml"
using PeninsulaHotelAndResortBookingSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
using PeninsulaHotelAndResortBookingSystem.Infrastructure.Security;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18b9a11f0eb5490c8c2ed77015b5969450a33d00", @"/Views/Booking/RoomRes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4170678d8d32153c0b00497204e489341649c84e", @"/Views/_ViewImports.cshtml")]
    public class Views_Booking_RoomRes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 4 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
          
            if (Model != null)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\" jumbotron\">\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                          
                            var user = this.User;
                            foreach (var facility in Model)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"card mb-3\">\r\n                                    <h3 class=\"card-header\">");
#nullable restore
#line 14 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                                                       Write(facility.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
                                    <div class=""card-body"">
                                        <h5 class=""card-title"">Special title treatment</h5>
                                        <h6 class=""card-subtitle text-muted"">Support card subtitle</h6>
                                    </div>
                                    <svg xmlns=""http://www.w3.org/2000/svg"" class=""d-block user-select-none"" width=""100%"" height=""200"" aria-label=""Placeholder: Image cap"" focusable=""false"" role=""img"" preserveAspectRatio=""xMidYMid slice"" viewBox=""0 0 318 180"" style=""font-size:1.125rem;text-anchor:middle"">
                                        <rect width=""100%"" height=""100%"" fill=""#868e96""></rect>
                                        <text x=""50%"" y=""50%"" fill=""#dee2e6"" dy="".3em"">Image cap</text>
                                    </svg>
                                    <div class=""card-body"">
                                        <p class=""card-text"">");
#nullable restore
#line 24 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                                                        Write(facility.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    </div>\r\n                                    <div class=\"card-body\">\r\n                                        <span>Rates:");
#nullable restore
#line 27 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                                               Write(facility.Rates);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\r\n                                        <span>Occupants:");
#nullable restore
#line 29 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                                                   Write(facility.Occupants);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                    </div>
                                    <div class=""card-footer text-muted"">
                                                                                     
                                                <a href=""#"" type=""button""");
            BeginWriteAttribute("onclick", " onclick=\"", 2103, "\"", 2182, 7);
            WriteAttributeValue("", 2113, "bookthis(\'", 2113, 10, true);
#nullable restore
#line 33 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
WriteAttributeValue("", 2123, facility.FacilityID, 2123, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2143, "\',\'", 2143, 3, true);
#nullable restore
#line 33 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
WriteAttributeValue("", 2146, ViewBag.dateIn, 2146, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2161, "\',\'", 2161, 3, true);
#nullable restore
#line 33 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
WriteAttributeValue("", 2164, ViewBag.dateOut, 2164, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2180, "\')", 2180, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Book now</a>\r\n                           \r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 37 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n");
#nullable restore
#line 41 "C:\Users\admin\source\repos\PeninsulaHotelAndResortBookingSystem\Views\Booking\RoomRes.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            DefineSection("confirmBook", async() => {
                WriteLiteral(@"

    <script>

        var baseUrl = location.origin;
        function bookthis(fID, dateIn, dateOut) {

            window.location = baseUrl + ""/Booking/confirmBooking"" + ""?dateArr="" + dateIn + ""&dateDep="" + dateOut + ""&RoomID="" + fID ;
      }
    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
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

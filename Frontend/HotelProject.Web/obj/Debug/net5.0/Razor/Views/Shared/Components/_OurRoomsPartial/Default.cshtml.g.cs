#pragma checksum "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2cf634f2ee333f1cae31a88edfc499310e0005b454198dcdd4ba989444bc8970"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_Shared_Components__OurRoomsPartial_Default), @"mvc.1.0.view", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Models.Staff

#nullable disable
    ;
#nullable restore
#line 4 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Models.Testimonial

#nullable disable
    ;
#nullable restore
#line 5 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.ServiceDto

#nullable disable
    ;
#nullable restore
#line 6 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.RegisterDto

#nullable disable
    ;
#nullable restore
#line 7 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.LoginDto

#nullable disable
    ;
#nullable restore
#line 8 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.AboutDto

#nullable disable
    ;
#nullable restore
#line 9 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.RoomDto

#nullable disable
    ;
#nullable restore
#line 10 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.TestimonialDto

#nullable disable
    ;
#nullable restore
#line 11 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.StaffDto

#nullable disable
    ;
#nullable restore
#line 12 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.SubscribeDto

#nullable disable
    ;
#nullable restore
#line 13 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.BookingDto

#nullable disable
    ;
#nullable restore
#line 14 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\_ViewImports.cshtml"
using HotelProject.Web.Dtos.ContactDto

#nullable disable
    ;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"2cf634f2ee333f1cae31a88edfc499310e0005b454198dcdd4ba989444bc8970", @"/Views/Shared/Components/_OurRoomsPartial/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"95f369ee44d9a90281edf6f38a54f41dfcc5d029f0e535b0995fd66c8c9275d2", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_Shared_Components__OurRoomsPartial_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<
#nullable restore
#line 1 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
       List<ResultRoomDto>

#line default
#line hidden
#nullable disable
    >
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""container-xxl py-5"">
    <div class=""container"">
        <div class=""text-center wow fadeInUp"" data-wow-delay=""0.1s"">
            <h6 class=""section-title text-center text-primary text-uppercase"">Odalarımız</h6>
            <h1 class=""mb-5"">Odalarımızı <span class=""text-primary text-uppercase"">Keşfedin</span></h1>
        </div>
        <div class=""row g-4"">
");
#nullable restore
#line 9 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"                <div class=""col-lg-4 col-md-6 wow fadeInUp"" data-wow-delay=""0.1s"">
                    <div class=""room-item shadow rounded overflow-hidden"">
                    <div class=""position-relative"">
                            <img class=""img-fluid""");
            BeginWriteAttribute("src", " src=\"", 728, "\"", 754, 1);
            WriteAttributeValue("", 734, 
#nullable restore
#line 14 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                         item.RoomCoverImage

#line default
#line hidden
#nullable disable
            , 734, 20, false);
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 755, "\"", 761, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <small class=\"position-absolute start-0 top-100 translate-middle-y bg-primary text-white rounded py-1 px-3 ms-4\">");
            Write(
#nullable restore
#line 15 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                                                          item.Price

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("$</small>\r\n                    </div>\r\n                    <div class=\"p-4 mt-2\">\r\n                        <div class=\"d-flex justify-content-between mb-3\">\r\n                            <h5 class=\"mb-0\">");
            Write(
#nullable restore
#line 19 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                              item.Title

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</h5>
                            <div class=""ps-2"">
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                                <small class=""fa fa-star text-primary""></small>
                            </div>
                        </div>
                        <div class=""d-flex mb-3"">
                            <small class=""border-end me-3 pe-3""><i class=""fa fa-bed text-primary me-2""></i>");
            Write(
#nullable restore
#line 29 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                            item.BedCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Yatak</small>\r\n                            <small class=\"border-end me-3 pe-3\"><i class=\"fa fa-bath text-primary me-2\"></i>");
            Write(
#nullable restore
#line 30 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                                                                             item.BathCount

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(" Banyo</small>\r\n                            <small><i class=\"fa fa-wifi text-primary me-2\"></i>Wifi</small>\r\n                        </div>\r\n                        <p class=\"text-body mb-3\">");
            Write(
#nullable restore
#line 33 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
                                                   item.Description

#line default
#line hidden
#nullable disable
            );
            WriteLiteral(@"</p>
                        <div class=""d-flex justify-content-between"">
                            <a class=""btn btn-sm btn-primary rounded py-2 px-4"" href=""/Booking/Index/"">Detayları Gör</a>
                                <a class=""btn btn-sm btn-dark rounded py-2 px-4"" href=""/Booking/Index/"">Rezervasyon Yap</a>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 41 "C:\Users\HP\source\repos\Project\Frontend\HotelProject.Web\Views\Shared\Components\_OurRoomsPartial\Default.cshtml"
        }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ResultRoomDto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\heysu\source\repos\MySalon\MySalon\Views\OnlineBooking\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa347b500922c6ea422cfcada56f16fa1bb1b5b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_OnlineBooking_Booking), @"mvc.1.0.view", @"/Views/OnlineBooking/Booking.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/OnlineBooking/Booking.cshtml", typeof(AspNetCore.Views_OnlineBooking_Booking))]
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
#line 1 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\_ViewImports.cshtml"
using MySalon;

#line default
#line hidden
#line 2 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\_ViewImports.cshtml"
using MySalon.Models;

#line default
#line hidden
#line 1 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\OnlineBooking\Booking.cshtml"
using MySalon.Controllers;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa347b500922c6ea422cfcada56f16fa1bb1b5b3", @"/Views/OnlineBooking/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4410dbba6612675ceb64a23ac590b12f9b5323a1", @"/Views/_ViewImports.cshtml")]
    public class Views_OnlineBooking_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<object>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\heysu\source\repos\MySalon\MySalon\Views\OnlineBooking\Booking.cshtml"
  
    ViewData["Title"] = "OnlineBooking";

#line default
#line hidden
            BeginContext(92, 92, true);
            WriteLiteral("    <header class=\"py-5 full-appointment-background\">\r\n    <div class=\"container\">\r\n        ");
            EndContext();
            BeginContext(184, 885, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fa347b500922c6ea422cfcada56f16fa1bb1b5b33771", async() => {
                BeginContext(190, 872, true);
                WriteLiteral(@"
            <div class=""form-row"">
                <div class=""form-group col-md-6"">
                    <label for=""inputUsername4"">Username</label>
                    <input type=""text"" class=""form-control"" id=""inputUsername4"" placeholder=""Login Username"">
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""selectDate4"">Select Date</label>
                    <input type=""date"" class=""form-control"" id=""selectDate4"" placeholder=""Pick Date"">
                </div>
                <div class=""form-group col-md-6"">
                    <label for=""selectTime"">Select Time</label>
                    <input type=""time"" class=""form-control"" id=""selectTime"">
                </div>
            </div>       
            <button type=""submit"" class=""btn btn-primary"">Make Appointment</button>
        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1069, 29, true);
            WriteLiteral("\r\n    </div>\r\n    </header>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<object> Html { get; private set; }
    }
}
#pragma warning restore 1591
#pragma checksum "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7a0f9617b048cf87f0f3ba2d87899fac58f61ac5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_SelectCenter), @"mvc.1.0.view", @"/Views/Register/SelectCenter.cshtml")]
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
#line 1 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\_ViewImports.cshtml"
using BloodDonation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\_ViewImports.cshtml"
using BloodDonation.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a0f9617b048cf87f0f3ba2d87899fac58f61ac5", @"/Views/Register/SelectCenter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a568f96a74cc5345d6d6d01171b52c76dc430b00", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_SelectCenter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CommonModels.Centre>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/banner/blood.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("max-height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
  
    ViewData["Title"] = "Select Center";
    Layout = "~/Views/Shared/_Layout.cshtml";
    var today = DateTime.Today.ToString("yyyy-MM-ddThh:mm").Replace('.',':');

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <section class=""main_slider_area"">
        <div class=""container"" style=""min-height: 40vh; padding-top: 10vh"">
            <div class=""row"">
                <div class=""col-md-5 mt-5 mb-5"">
                    <h1 style=""line-height: 70px; font-size: 52px"">Center & Timing</h1>
                </div>
                <div class=""col-md-6 offset-md-1"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7a0f9617b048cf87f0f3ba2d87899fac58f61ac55681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section class=\"feature_area\">\r\n        <div class=\"container\">\r\n            <div class=\"c_title\">\r\n                <img src=\"img/icon/title-icon.png\"");
            BeginWriteAttribute("alt", " alt=\"", 916, "\"", 922, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <h6>Select Center & Timing Slot</h6>\r\n            </div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a0f9617b048cf87f0f3ba2d87899fac58f61ac57364", async() => {
                WriteLiteral(@"
                <div class=""row"">
                    <div class=""col-md-8"">
                        <table class=""table"">
                            <thead>
                                <tr>
                                    <th>
                                        S.No.
                                    </th>
                                    <th>
                                        ");
#nullable restore
#line 38 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
                                   Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                    </th>\r\n                                    <th></th>\r\n                                </tr>\r\n                            </thead>\r\n                            <tbody>\r\n");
#nullable restore
#line 44 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
                                 foreach (var item in Model)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\r\n                                        <td>\r\n                                            <input name=\"center_id\" type=\"radio\"");
                BeginWriteAttribute("value", " value=\"", 1970, "\"", 1986, 1);
#nullable restore
#line 48 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
WriteAttributeValue("", 1978, item.Id, 1978, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\" required />\r\n                                        </td>\r\n                                        <td>\r\n                                            ");
#nullable restore
#line 51 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        </td>\r\n                                    </tr>\r\n");
#nullable restore
#line 54 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""form-group"">
                            <label class=""control-label"">Select Date Time:</label>
                            <input class=""form-control"" type=""datetime-local"" id=""timing"" name=""timing""");
                BeginWriteAttribute("min", " min=\"", 2710, "\"", 2722, 1);
#nullable restore
#line 61 "C:\Users\Er.Navjot\Documents\Visual Studio 2019\BloodDonation\BloodDonation\Views\Register\SelectCenter.cshtml"
WriteAttributeValue("", 2716, today, 2716, 6, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required />
                            <span class=""text-danger field-validation-valid""></span>
                        </div>
                        <div class=""col-12 text-center mt-4"">
                            <input type=""submit"" value=""Review"" class=""btn btn-success btn-lg"" />
                        </div>
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </section>\r\n\r\n            \r\n            \r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CommonModels.Centre>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8677192a4743455836c167f873126c6f14ac554"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_PatientInformation), @"mvc.1.0.view", @"/Views/Patient/PatientInformation.cshtml")]
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
#line 1 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\_ViewImports.cshtml"
using HastalikTakibi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\_ViewImports.cshtml"
using HastalikTakibi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8677192a4743455836c167f873126c6f14ac554", @"/Views/Patient/PatientInformation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5769fc0e714debf1b4fddcd18bc0768d0e93aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Patient_PatientInformation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HastalikTakibi.DAL.Models.Database.PatientInformationView>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color:beige;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
  
    ViewData["Title"] = "PatientInformation";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8677192a4743455836c167f873126c6f14ac5543976", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a8677192a4743455836c167f873126c6f14ac5544946", async() => {
                WriteLiteral(@"
    <div class=""container"" style=""width:1500px; margin-left:-255px;"">
        <div>
            <h4 style=""color: #ff9030; text-align: center;border: solid 2px black; margin-top: 2px; background-color: green;height: 45px; width: 1520px;"">Hasta Bilgisi</h4>
            <div class=""row"">
                <div class=""col-md-4""><a class=""btn btn-success btnAdd"" style=""margin-top:5px;""");
                BeginWriteAttribute("href", " href=\"", 621, "\"", 677, 2);
                WriteAttributeValue("", 628, "/Patient/PatientInformationAdd/", 628, 31, true);
#nullable restore
#line 15 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
WriteAttributeValue("", 659, ViewBag.PatientId, 659, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Yeni Hastalık ekle </a></div>\r\n                <div class=\"col-md-8\" style=\"margin-left: -190px; font-size: xx-large;\">");
#nullable restore
#line 16 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                                                                                   Write(ViewBag.PatientName);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
            </div>
            

        </div>
        <table id="" example"" class=""table table-danger""style="" margin-top: 20px;  background-color: beige; width: 1455px;"">
            <thead>
                <tr>
                    <th> Id</th>
                    <th> Hastalık Adı</th>
                    <th> Hastalanma zamanı</th>
                    <th> İyileşme zamanı</th>
                    <th> Hatalandığı il</th>
                    <th> Hastalandıgı ilçe</th>
                    <th> Belirtiler</th>
                    <th> Güncelle</th>
                    <th> Sil</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 36 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                 foreach (var information in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <th>");
#nullable restore
#line 39 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 40 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.DiseaseName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.WhenIll);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.RecoveryTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.ProvinceName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.DistrictName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 45 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                   Write(information.Symptoms);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-success btnUpdate\"");
                BeginWriteAttribute("href", " href=\"", 2024, "\"", 2080, 2);
                WriteAttributeValue("", 2031, "/Patient/PatientInformationUpdate/", 2031, 34, true);
#nullable restore
#line 46 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
WriteAttributeValue("", 2065, information.Id, 2065, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 46 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                                                                                                                          Write(information.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">Güncelle </a></td>\r\n                    <td><a class=\"btn btn-success btnUpdate\"");
                BeginWriteAttribute("href", " href=\"", 2188, "\"", 2244, 2);
                WriteAttributeValue("", 2195, "/Patient/PatientInformationDelete/", 2195, 34, true);
#nullable restore
#line 47 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
WriteAttributeValue("", 2229, information.Id, 2229, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data-id=\"");
#nullable restore
#line 47 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                                                                                                                          Write(information.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">sil </a></td>\r\n                </tr>\r\n");
#nullable restore
#line 49 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Patient\PatientInformation.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HastalikTakibi.DAL.Models.Database.PatientInformationView>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9a05f767ba5cc09e7268b1a311e9458040ac962"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Index), @"mvc.1.0.view", @"/Views/Category/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9a05f767ba5cc09e7268b1a311e9458040ac962", @"/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5769fc0e714debf1b4fddcd18bc0768d0e93aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HastalikTakibi.DAL.Models.Database.Category>>
    {
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
#line 2 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
  
    ViewData["Title"] = "Category";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a05f767ba5cc09e7268b1a311e9458040ac9623527", async() => {
                WriteLiteral("\r\n    <script type = \"text/javascript\" language = \"JavaScript\"></script>\r\n   ");
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
            WriteLiteral("\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9a05f767ba5cc09e7268b1a311e9458040ac9624577", async() => {
                WriteLiteral(@"
       
       <div class= ""container"">
            <br/>
            <div>
                <div class=""gridHeader""> Katgori Listesi </div>
                <a class=""btn btn-success btnAdd"" href=""/Category/CategoryAdd""> Ekle</a>
                <table id=""example"" class=""table table-strip table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th> id </th>

                            <th> Name </th>

                            <th>CreateTime </th>

                            <th>LastUpdateTime </th>

                            <th> Update </th>

                            <th> Delete </th>
                        </tr>
                    </thead>

                    <tbody>
");
#nullable restore
#line 36 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
                         foreach (var category in Model)
                        {


#line default
#line hidden
#nullable disable
                WriteLiteral("                            <tr>\r\n\r\n                                <th> ");
#nullable restore
#line 41 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
                                Write(category.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </th>\r\n                                <td> ");
#nullable restore
#line 42 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
                                Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                                <td> ");
#nullable restore
#line 43 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
                                Write(category.CreateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td> ");
#nullable restore
#line 44 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
                                Write(category.LastUpdateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\r\n                                <td><a class=\"btn btn-success btnUpdate\"");
                BeginWriteAttribute("href", " href=\"", 1517, "\"", 1561, 2);
                WriteAttributeValue("", 1524, "/Category/CategoryUpdate/", 1524, 25, true);
#nullable restore
#line 45 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
WriteAttributeValue("", 1549, category.Id, 1549, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data -");
                BeginWriteAttribute("id", " id=\"", 1569, "\"", 1586, 1);
#nullable restore
#line 45 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
WriteAttributeValue("", 1574, category.Id, 1574, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Güncelle </a></td>\r\n\r\n                                <td><a class=\"btn btn-danger btnDlete\"");
                BeginWriteAttribute("href", " href=\"", 1680, "\"", 1724, 2);
                WriteAttributeValue("", 1687, "/Category/CategoryDelete/", 1687, 25, true);
#nullable restore
#line 47 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
WriteAttributeValue("", 1712, category.Id, 1712, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" data -");
                BeginWriteAttribute("id", " id=\"", 1732, "\"", 1749, 1);
#nullable restore
#line 47 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"
WriteAttributeValue("", 1737, category.Id, 1737, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("> Sil </a></td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 50 "E:\BELGELER\projects\HastalikTakibi\HastalikTakibi\Views\Category\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </tbody>\r\n\r\n                </table>\r\n              \r\n            </div>\r\n    </div>\r\n       \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HastalikTakibi.DAL.Models.Database.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591

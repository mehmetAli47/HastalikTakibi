#pragma checksum "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e228002f833cdc6f30b14842b1b7052ff569b3a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disease_DiseaseAdd), @"mvc.1.0.view", @"/Views/Disease/DiseaseAdd.cshtml")]
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
#line 1 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\_ViewImports.cshtml"
using HastalikTakibi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\_ViewImports.cshtml"
using HastalikTakibi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e228002f833cdc6f30b14842b1b7052ff569b3a", @"/Views/Disease/DiseaseAdd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e5769fc0e714debf1b4fddcd18bc0768d0e93aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Disease_DiseaseAdd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HastalikTakibi.Models.DiseaseVm>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("DiseaseAdd"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-left:35%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml"
  
    ViewData["Title"] = "DiseaseAdd";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e228002f833cdc6f30b14842b1b7052ff569b3a5625", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
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
            WriteLiteral("\r\n<style>\r\n    .tableName {\r\n        text-align: center;\r\n    }\r\n\r\n    .DiseaseAdd {\r\n        margin: 50px;\r\n        width: 100%;\r\n    }\r\n</style>\r\n<h3 class=\"tableName\">Hastal??k Ekleme</h3>\r\n<div class=\"row\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e228002f833cdc6f30b14842b1b7052ff569b3a6957", async() => {
                WriteLiteral(@"

        <div class=""form-group"">

            <div class=""row"">
                <div class=""col-sm-4"">
                    <label> ADI</label>
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <input class=""form-control"" id=""Name"" name=""Name"" />
                </div>
                <!-- /.col-sm-6 -->
            </div>


        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <label> ??LK G??R??LME TAR??H??</label>
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <input class=""form-control"" name=""FirstSeenDate"" id=""FirstSeenDate"" type=""datetime-local"" />
                </div>
                <!-- /.col-sm-6 -->
            </div>


        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-4"">
              ");
                WriteLiteral(@"      <label> S??STEMDEK?? KATEGOR??LER</label>
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <select class=""form-control"" name=""CategoryList"" id=""CategoryList"">
                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e228002f833cdc6f30b14842b1b7052ff569b3a8576", async() => {
                    WriteLiteral("se??iniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml"
                         foreach (SelectListItem item in ViewBag.CategoryList)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e228002f833cdc6f30b14842b1b7052ff569b3a10483", async() => {
#nullable restore
#line 64 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml"
                                                   Write(item.Text);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml"
                               WriteLiteral(item.Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 65 "C:\Users\mehme\Documents\GitHub\HastalikTakibi\HastalikTakibi\HastalikTakibi\Views\Disease\DiseaseAdd.cshtml"

                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    </select>
                </div>
                <!-- /.col-sm-6 -->
            </div>

        </div>

        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <label></label>
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <button  class=""btn btn-success"" type=""button"" id=""btnAdd""><i class=""fa fa-plus""></i></button>
                    <button class=""btn btn-danger"" type=""button"" id=""btnRemove""><i class=""fa fa-trash""></i></button>
                </div>
                <!-- /.col-sm-6 -->
            </div>



        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-4"">
                    <label>SE????LEN KATEGOR??LER</label>
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <select class=""form-control"" n");
                WriteLiteral(@"ame=""CategoryIdList"" id=""CategoryIdList"" style=""min-height:100px"" multiple>
                    </select>
                </div>
                <!-- /.col-sm-6 -->
            </div>

        </div>
        <div class=""form-group"">
            <div class=""row"">
                <div class=""col-sm-4"">
                </div>
                <!-- /.col-sm-6 -->
                <div class=""col-sm-8"">
                    <input style="" width: 150px; "" id=""btnSbmit"" type=""submit"" value=""Ekle"" class=""btn btn-primary"" />
                </div>
                <!-- /.col-sm-6 -->
            </div>

        </div>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e228002f833cdc6f30b14842b1b7052ff569b3a15707", async() => {
                WriteLiteral("listeye geri d??n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<script>
    $(document).ready(function () {
        $('#btnAdd').click(function () {

            var selectedCategoryId = $('#CategoryList option:selected').val();
            var selectedCategoryName = $('#CategoryList option:selected').text();
            if (selectedCategoryId != """") {
                var options = $(""#CategoryIdList option"");
                var found = false;
                for (var i = 0; i < options.length; i++) {
                    if ($(options).eq(i).val() == selectedCategoryId) {
                        found = true;
                        break;
                    }
                }
                if (!found)
                    $(""#CategoryIdList"").append(new Option(selectedCategoryName, selectedCategoryId));
                else
                    alert(""Bu kategori zaten eklidir"");

            }

        });

        $('#btnRemove').click(function () {
            $('#CategoryIdList option:selected').remove();
        });

       ");
            WriteLiteral(" $(\'#btnSbmit\').click(function () {\r\n            $(\'#CategoryIdList option\').prop(\'selected\', true);\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HastalikTakibi.Models.DiseaseVm> Html { get; private set; }
    }
}
#pragma warning restore 1591

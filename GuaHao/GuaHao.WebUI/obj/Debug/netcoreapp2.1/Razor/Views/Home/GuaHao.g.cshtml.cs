#pragma checksum "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\Home\GuaHao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3433428133f5372f8320748f65c323af45f01ce9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GuaHao), @"mvc.1.0.view", @"/Views/Home/GuaHao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/GuaHao.cshtml", typeof(AspNetCore.Views_Home_GuaHao))]
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
#line 1 "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\_ViewImports.cshtml"
using GuaHao.WebUI;

#line default
#line hidden
#line 2 "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\_ViewImports.cshtml"
using GuaHao.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3433428133f5372f8320748f65c323af45f01ce9", @"/Views/Home/GuaHao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7619dbad283b25bc139b2591057d6df50b7484d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GuaHao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("selected", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("(item,index) in hosList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("item.id+\'-\'+item.hospitalType"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("(sitem,sindex) in item.departments"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("sitem.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in dateList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in sxwList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("item.Id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in docList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("item.doctorId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "-1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("v-for", new global::Microsoft.AspNetCore.Html.HtmlString("item in bxList"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(":value", new global::Microsoft.AspNetCore.Html.HtmlString("item.id"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\Home\GuaHao.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 519, true);
            WriteLiteral(@"<div id=""app"">

    <div class=""page__hd"">
        <h1 class=""page__title"">
            GuoHao.WebUI
        </h1>
        <p class=""page__desc"">WeUI 是一套同微信原生视觉体验一致的基础样式库，由微信官方设计团队为微信内网页和微信小程序量身设计，令用户的使用感知更加统一。</p>
    </div>
    
    <div class=""weui-cells"">

        <div class=""weui-cells"">
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""hosId"" v-on:change=""changeHos"">
                        ");
            EndContext();
            BeginContext(564, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bca7532267524ceb83fd3e9f8dd79864", async() => {
                BeginContext(594, 4, true);
                WriteLiteral("选择医院");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(607, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(633, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fefdf13360b24ae88843b1b3c301807c", async() => {
                BeginContext(712, 13, true);
                WriteLiteral("{{item.name}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(734, 266, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""catId"">
                        ");
            EndContext();
            BeginContext(1000, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7fb2db8859d7405699bc40e66e0f4bb2", async() => {
                BeginContext(1018, 4, true);
                WriteLiteral("选择科室");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1031, 149, true);
            WriteLiteral("\r\n                        <optgroup v-for=\"(item,index) in catList\" :value=\"item.id\" :label=\"item.sdCategoryFirstName\">\r\n                            ");
            EndContext();
            BeginContext(1180, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2a7b9e910e44738bf88f6af3c7c6689", async() => {
                BeginContext(1249, 14, true);
                WriteLiteral("{{sitem.name}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1272, 307, true);
            WriteLiteral(@"
                        </optgroup>
                    </select>
                </div>
            </div>
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""orderDate"">
                        ");
            EndContext();
            BeginContext(1579, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "de77a38986744efe99c72e1a624aaf59", async() => {
                BeginContext(1597, 4, true);
                WriteLiteral("选择日期");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1610, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(1636, 50, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd81fcad7c364cbd8beadcf01213c0d5", async() => {
                BeginContext(1669, 8, true);
                WriteLiteral("{{item}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1686, 631, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""weui-cell"">
                <div class=""weui-cell__hd""><label class=""weui-label"" style=""font-weight:normal;"">挂号时间</label></div>
                <div class=""weui-cell__bd"">
                    <input class=""weui-input"" type=""text"" placeholder=""07:00"" v-model=""orderTime"">
                </div>
            </div>
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""sxw"" v-on:change=""changeSXW"">
                        ");
            EndContext();
            BeginContext(2317, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "692d7a01507d4c37be04f51b9ead52f3", async() => {
                BeginContext(2335, 6, true);
                WriteLiteral("选择上午下午");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2350, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2376, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ed378a908184e619bc03e70b470bd20", async() => {
                BeginContext(2425, 13, true);
                WriteLiteral("{{item.Name}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2447, 268, true);
            WriteLiteral(@"

                    </select>
                </div>
            </div>
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""docId"">
                        ");
            EndContext();
            BeginContext(2715, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a4008228456246ffa7912a4ce65643ce", async() => {
                BeginContext(2733, 4, true);
                WriteLiteral("选择大夫");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2746, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2866, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2890, 159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "06a0f5a9c92b4b799244163a8e7ff5f1", async() => {
                BeginContext(2945, 95, true);
                WriteLiteral("{{item.doctorName+\',\'+item.doctorTitleName+\' 余\'+item.remainAvailableNumber+\' ￥\'+item.totalFee}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3049, 265, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""weui-cell weui-cell_select"">
                <div class=""weui-cell__bd"">
                    <select class=""weui-select"" v-model=""bxId"">
                        ");
            EndContext();
            BeginContext(3314, 34, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd579559202740d39f08ae27cfd64fbb", async() => {
                BeginContext(3333, 6, true);
                WriteLiteral("选择报销类型");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3348, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3374, 70, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "542286ce393f4a8999e0cf569abfa0ec", async() => {
                BeginContext(3422, 13, true);
                WriteLiteral("{{item.name}}");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3444, 7221, true);
            WriteLiteral(@"
                    </select>
                </div>
            </div>
            <div class=""weui-cell"">
                <div class=""weui-cell__hd""><label class=""weui-label""  style=""font-weight:normal;"">病人Id</label></div>
                <div class=""weui-cell__bd"">
                    <input class=""weui-input"" type=""number"" pattern=""[0-9]*"" v-model=""patientId"" placeholder=""请输入病人Id"">
                </div>
            </div>
        </div>
        <div class=""login-btn-container"">
            <a href=""javascript:;"" v-on:click=""saveTPL"" class=""weui-btn weui-btn_primary"">保存模版下一步</a>
        </div>

        <div class=""js_dialog"" v-show=""alertShow"">
            <div class=""weui-mask""></div>
            <div class=""weui-dialog"">
                <div class=""weui-dialog__bd"">{{alertMSG}}</div>
                <div class=""weui-dialog__ft"">
                    <a href=""javascript:;"" v-on:click=""hideAlert"" class=""weui-dialog__btn weui-dialog__btn_primary"">知道了</a>
                </div>
       ");
            WriteLiteral(@"     </div>
        </div>

    </div>



</div>
<script>
    var app = new Vue({
        el: '#app',
        data: {
            hosId: '0',
            hosList: [],
            catId:'0',
            catList: [],
            orderDate: '0',
            orderTime:'07:00',
            dateList: [],
            sxw: '0',
            sxwList: [{ Id: '1', Name: '上午' }, { Id: '2', Name: '下午' }],
            docId: '0',
            docList: [],
            bxId: '-1',
            bxList: [
                { id: '1', name: '医疗保险' },
                { id: '2', name: '商业保险' },
                { id: '3', name: '公费医疗' },
                { id: '4', name: '新农合' },
                { id: '5', name: '异地医保' },
                { id: '6', name: '红本医疗' },
                { id: '7', name: '工伤' },
                { id: '8', name: '一老一小' },
                { id: '9', name: '超转' },
                { id: '10', name: '自费' },
                { id: '11', name: '生育险' },
                { id: '12', nam");
            WriteLiteral(@"e: '其他' },
            ],
            patientId: '',
            alertShow: false,
            alertMSG:''
        },
        mounted: function () {
            this.getHospitalList();
            this.initDateList();

        },
        methods: {
            getHospitalList: function () {
                var that = this;
                $.ajax({
                    url: '/Home/HostpitalList',
                    type: 'post',
                    success: function (res) {
                        if (res.code == 0) {
                            that.hosList = JSON.parse(res.data).data;
                            
                            console.log(JSON.parse(res.data).data);
                        }
                    }
                })
            },
            changeHos: function () {
                var that = this;
                var hid = that.hosId.split('-')[0];
                var htype = that.hosId.split('-')[1];
                $.ajax({
                    ");
            WriteLiteral(@"url: '/Home/CategoryList',
                    type: 'post',
                    data: { hid: hid, htype: htype},
                    success: function (res) {
                        if (res.code == 0) {
                            that.catList = JSON.parse(res.data).data;
                            that.catId = '0';
                        }
                    }
                })
            },

            changeSXW: function () {
                var that = this;
                var hid = that.hosId.split('-')[0];
                $.ajax({
                    url: '/Home/DoctorList',
                    type: 'post',
                    data: { hid: hid, did: that.catId, sxw: that.sxw, date: that.orderDate },
                    success: function (res) {

                        that.docId = '0';
                        if (res.code == 0) {
                            if (res.data.length == 0) {
                                that.alertMSG = ""没有大夫可以约，请换其他日期。"";
                  ");
            WriteLiteral(@"              that.alertShow = true;
                            }
                            that.docList = res.data;
                            console.log(res.data);
                            
                        } else { 
                            alert(res.data);

                        }
                    }
                })
            },
            saveTPL: function () {
                var that = this;
                var hosObj = that.hosList.find(function (item) { return item.id == that.hosId.split('-')[0] });

                var allCatList = [];
                that.catList.forEach(function (item) {
                    item.departments.forEach(function (sitem) { 
                        allCatList.push(sitem);
                    });
                 });
                
                var catObj = allCatList.find(function (item) { return item.id == that.catId });
                var docObj = this.docList.find(function (item) { return item.id = that.docId }");
            WriteLiteral(@");
                var sxwVal = that.sxw == '1' ? '上午' : '下午';
                var name = hosObj.name + '/' + catObj.name + '/' + that.orderDate + '/' + sxwVal + '/' + docObj.doctorName + '/' + that.orderTime;
                //string dutySourceId,string hospitalId,string departmentId,string doctorId,string patientId,string reimbursementType,string smsVerifyCode, string cookieValue, string hospitalCardId = """", string medicareCardId = """", string childrenBirthday="""", string dlRegType=""-1"", string dlMajorId="""",string mapDoctorId=""""
                var para = docObj.dutySourceId + '-' + docObj.hospitalId + '-' + docObj.departmentId + '-' + docObj.doctorId + '-' + that.patientId + '-' + that.bxId + '-' + that.sxw;
                $.ajax({
                    url: '/Home/SaveGuaHaoTPL',
                    type: 'post',
                    data: { name:name, para: para},
                    success: function (res) {
                        
                        if (res.code == 0) {
                  ");
            WriteLiteral(@"          console.log('save ok');
                            //window.location.href = ""Run"";

                        } else {
                            alert(res.data);

                        }
                    }
                })
            },
            hideAlert: function () {
                this.alertShow = false;
            },
            initDateList: function () {
                var dtNow = new Date();
                this.orderDate = '0';// this.formateDate(dtNow)
                for (var i = 1; i <= 7; i++) {
                    var cdate = dtNow.getDate() + 1;
                    dtNow.setDate(cdate);
                    this.dateList.push(this.formateDate(dtNow));
                }
            },

            formateDate:function (dt) {
                var year = dt.getFullYear();
                var month = ('0' + (dt.getMonth() + 1)).substr(-2);
                var date = ('0' + dt.getDate()).substr(-2);
                return year + ""-"" + month + ""-"" + d");
            WriteLiteral("ate;\r\n            }\r\n        }\r\n    })\r\n\r\n\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

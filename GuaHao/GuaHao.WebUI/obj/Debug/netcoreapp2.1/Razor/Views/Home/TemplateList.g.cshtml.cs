#pragma checksum "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\Home\TemplateList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92b0f710d6de7877bd9808f67f5db5008f3fcfca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TemplateList), @"mvc.1.0.view", @"/Views/Home/TemplateList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TemplateList.cshtml", typeof(AspNetCore.Views_Home_TemplateList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b0f710d6de7877bd9808f67f5db5008f3fcfca", @"/Views/Home/TemplateList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7619dbad283b25bc139b2591057d6df50b7484d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_TemplateList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\Home\TemplateList.cshtml"
  
    ViewData["Title"] = "选择模版";

#line default
#line hidden
            BeginContext(40, 1554, true);
            WriteLiteral(@"<div id=""app"">

    <div class=""page__hd"">
        <h1 class=""page__title"">
            GuoHao.WebUI
        </h1>
        <p class=""page__desc"">WeUI 是一套同微信原生视觉体验一致的基础样式库，由微信官方设计团队为微信内网页和微信小程序量身设计，令用户的使用感知更加统一。</p>
    </div>

    <div class=""weui-cells"">

        <div class=""weui-cells weui-cells_radio"">
            <label class=""weui-cell weui-check__label"" v-for=""item in tplList"">
                <div class=""weui-cell__bd"">
                    <p>{{item.name}}</p>
                </div>
                <div class=""weui-cell__ft"">
                    <input type=""radio"" class=""weui-check"" name=""radio1"" id=""x11"">
                    <span class=""weui-icon-checked""></span>
                </div>
            </label>
        </div>
        <div class=""weui-cell weui-cell_vcode"">
            <div class=""weui-cell__hd"">
                <label class=""weui-label"">验证码</label>
            </div>
            <div class=""weui-cell__bd"">
                <input class=""weui-input"" type=""tel"" pa");
            WriteLiteral(@"ttern=""[0-9]*"" v-model=""checkCode"" placeholder=""请输入验证码"">
            </div>
            <div class=""weui-cell__ft"">
                <button class=""weui-vcode-btn"" v-on:click=""getCheckCode"">获取验证码</button>
            </div>
        </div>
        <div class=""login-btn-container"">
            <a href=""javascript:;"" v-on:click=""saveGuaHao"" class=""weui-btn weui-btn_primary"">提交等待挂号</a>
        </div>

    </div>



</div>
<script>
    var app = new Vue({
        el: '#app',
        data: {
            tplStr: '");
            EndContext();
            BeginContext(1595, 30, false);
#line 50 "E:\Yesway\Liang\Test\VSTest\Liang.Projects\GuaHao.WebUI\Views\Home\TemplateList.cshtml"
                Write(Html.Raw(ViewBag.templateData));

#line default
#line hidden
            EndContext();
            BeginContext(1625, 2527, true);
            WriteLiteral(@"',
            tplList: [],
            checkCode:'',
        },
        mounted: function () {
            var tplArr = this.tplStr.split('#');
            for (var i = 0; i < tplArr.length; i++) {
                var id = tplArr[i].split(',')[1];
                var name = tplArr[i].split(',')[0];
                this.tplList.push({ id:id, name:name});
            }
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
            getCheckCode: function () {
                var that = this;
                $.ajax({
");
            WriteLiteral(@"                    url: '/Home/GetCheckCode',
                    type: 'post',
                    success: function (res) {
                        if (res.code == 200) {
                            alert('发送成功')
                        } else {

                            alert('发送失败')
                        }
                    }
                })
            },
            saveGuaHao: function () {
                var that = this;
                $.ajax({
                    url: '/Home/SaveGuaHao',
                    type: 'post',
                    data: { code: that.checkCode },
                    success: function (res) {
                        if (res.code == 0) {
                            setTimeout(function () {
                                that.goGuaHao();
                            })
                        } else { 


                        }
                    }
                })
            },

            goGuaHao: function () {
            ");
            WriteLiteral(@"    var that = this;
                $.ajax({
                    url: '/Home/GoGuaHao',
                    type: 'post',
                    success: function (res) {

                        console.log(""挂号结果。"" + res);
                        alert(res.msg);
                        //if (res.code == 0) {
                        //} else {


                        //}
                    }
                })
            }
        }
    })
    
</script>");
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

#pragma checksum "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f362a8d8c6d9b9f5a0314bdf1cf5cf4fa9d4803a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_SupplierModify), @"mvc.1.0.razor-page", @"/Pages/FytAdmin/Purchase/SupplierModify.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/FytAdmin/Purchase/SupplierModify.cshtml", typeof(FytSoa.Web.Pages.FytAdmin.Purchase.Pages_FytAdmin_Purchase_SupplierModify), null)]
namespace FytSoa.Web.Pages.FytAdmin.Purchase
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\_ViewImports.cshtml"
using FytSoa.Web;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f362a8d8c6d9b9f5a0314bdf1cf5cf4fa9d4803a", @"/Pages/FytAdmin/Purchase/SupplierModify.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21c44af9864cf57cf01e8fd1fe389a8e352e148c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_FytAdmin_Purchase_SupplierModify : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("layui-form form-cus"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("app"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
  
    ViewData["Title"] = "供应商管理";
    Layout = "~/Pages/FytAdmin/_Layout.cshtml";

#line default
#line hidden
            BeginContext(160, 390, true);
            WriteLiteral(@"<style>
    .layui-textarea {
        min-height: 60px;
    }
    .layui-form-item .layui-input-inline {
        width: 220px;
    }
    .addAttr {
        cursor: pointer;
    }
    .addAttr i {
        vertical-align: middle;
        position: relative;
        top: -2px;
        margin-right: 5px;
        color: #666;
        font-size: 24px;        
    }
</style>
");
            EndContext();
            BeginContext(550, 3159, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0ca4aba8d3d5423d98544e018eb66b44", async() => {
                BeginContext(603, 175, true);
                WriteLiteral("\r\n    <div class=\"layui-form-item\">\r\n        <label class=\"layui-form-label\">供应商名称</label>\r\n        <div class=\"layui-input-block\">\r\n            <input type=\"text\" name=\"Name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 778, "\"", 806, 1);
#line 30 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 786, Model.Supplier.Name, 786, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(807, 308, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请填写公司名称"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">联系人</label>
        <div class=""layui-input-block"">
            <input type=""text"" name=""Contacts""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1115, "\"", 1147, 1);
#line 36 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 1123, Model.Supplier.Contacts, 1123, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1148, 374, true);
                WriteLiteral(@" lay-verify=""required"" lay-verType=""tips"" lay-verType=""tips"" autocomplete=""off"" placeholder=""请输入联系人"" class=""layui-input"">
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">联系电话</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Mobile""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1522, "\"", 1552, 1);
#line 43 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 1530, Model.Supplier.Mobile, 1530, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1553, 310, true);
                WriteLiteral(@" lay-verify=""required|phone"" lay-verType=""tips"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <label class=""layui-form-label"">邮箱</label>
            <div class=""layui-input-inline"">
                <input type=""text"" name=""Email""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1863, "\"", 1892, 1);
#line 49 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 1871, Model.Supplier.Email, 1871, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1893, 897, true);
                WriteLiteral(@" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"" v-for=""it,index in attrList"">
        <div class=""layui-inline"">
            <label class=""layui-form-label"">自定义</label>
            <div class=""layui-input-inline"">
                <input type=""text"" v-model=""it.Name"" placeholder=""如经营地址"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-inline"">
            <div class=""layui-input-inline"">
                <input type=""text"" v-model=""it.Value"" placeholder=""北京-朝阳"" autocomplete=""off"" class=""layui-input"">
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <div class=""layui-inline"">
            <label class=""layui-form-label""></label>
            <div class=""layui-input-inline"">
                <span class=""addAttr"" ");
                EndContext();
                BeginContext(2791, 320, true);
                WriteLiteral(@"@click=""addAttrRow()""><i class=""layui-icon layui-icon-add-circle""></i>添加自定义</span>
            </div>
        </div>
    </div>
    <div class=""layui-form-item"">
        <label class=""layui-form-label"">备注</label>
        <div class=""layui-input-block"">
            <textarea name=""Summary"" class=""layui-textarea"">");
                EndContext();
                BeginContext(3112, 22, false);
#line 77 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
                                                       Write(Model.Supplier.Summary);

#line default
#line hidden
                EndContext();
                BeginContext(3134, 378, true);
                WriteLiteral(@"</textarea>
        </div>
    </div>

    <div class=""layui-form-item"">
        <div class=""layui-input-block"">
            <button class=""layui-btn"" lay-submit="""" lay-filter=""submit"">立即提交</button>
            <button type=""button"" class=""layui-btn layui-btn-primary btn-open-close"">取消</button>
        </div>
    </div>
    <input type=""hidden"" name=""Guid"" id=""Guid""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3512, "\"", 3540, 1);
#line 87 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 3520, Model.Supplier.Guid, 3520, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3541, 44, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"AddDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3585, "\"", 3616, 1);
#line 88 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 3593, Model.Supplier.AddDate, 3593, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3617, 46, true);
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"Attribute\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 3663, "\"", 3696, 1);
#line 89 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
WriteAttributeValue("", 3671, Model.Supplier.Attribute, 3671, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3697, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            EndContext();
            BeginContext(3709, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3728, 335, true);
                WriteLiteral(@"
    <script>
        var app, data = {
            attrList: [
                { 'Name': '', 'Value': ''}
            ]
        };
        var vm = new Vue({
            el: ""#app"",
            data: data,
            created: function () { 
                var that = this;                
                var attrStr = '");
                EndContext();
                BeginContext(4064, 34, false);
#line 103 "E:\2018Project\ERP项目\SoaProJect\FytSoa.Web\Pages\FytAdmin\Purchase\SupplierModify.cshtml"
                          Write(Html.Raw(Model.Supplier.Attribute));

#line default
#line hidden
                EndContext();
                BeginContext(4098, 1552, true);
                WriteLiteral(@"';
                if (attrStr != """") {
                    that.attrList = JSON.parse(attrStr);
                }               
            },
            methods: {
                addAttrRow: function () {
                    this.attrList.push({
                        'Name': '', 'Value': ''
                    });
                }
            }
        });
        layui.config({
            base: '/themes/js/modules/'
        }).use(['layer', 'jquery', 'common', 'form'], function () {
            var form = layui.form, $ = layui.$, os = layui.common;
            var index = parent.layer.getFrameIndex(window.name);
            //监听提交
            form.on('submit(submit)', function (data) {
                var urls = ""api/purchase/addsupplier"";
                if ($(""#Guid"").val()) {
                    urls = ""api/purchase/editsupplier"";
                }
                data.field.Attribute = JSON.stringify(vm.attrList);
                os.ajax(urls, data.field, function(res) {");
                WriteLiteral(@"
                    if (res.statusCode === 200) {
                        var $$ = parent.layui.jquery;
                        $$(""#isSave"").val('1');
                        parent.layer.close(index);
                    } else {
                        os.error(res.message);
                    }
                });
                return false;
            });
            $("".btn-open-close"").on('click', function () {
                parent.layer.close(index);
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(5653, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModifyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModifyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModifyModel>)PageContext?.ViewData;
        public FytSoa.Web.Pages.FytAdmin.Purchase.SupplierModifyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

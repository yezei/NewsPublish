#pragma checksum "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a0bcee770ed528e4068dc8a882b329dfdda7a3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_NewsClassifyEdit), @"mvc.1.0.view", @"/Areas/Admin/Views/News/NewsClassifyEdit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/News/NewsClassifyEdit.cshtml", typeof(AspNetCore.Areas_Admin_Views_News_NewsClassifyEdit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a0bcee770ed528e4068dc8a882b329dfdda7a3c", @"/Areas/Admin/Views/News/NewsClassifyEdit.cshtml")]
    public class Areas_Admin_Views_News_NewsClassifyEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NewsPublish.Model.Response.ResponseModel>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
  
    ViewData["Title"] = "NewsClassifyEdit";

#line default
#line hidden
            BeginContext(103, 25, true);
            WriteLiteral("<!DOCTYPE HTML>\r\n<html>\r\n");
            EndContext();
            BeginContext(128, 1015, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a0bcee770ed528e4068dc8a882b329dfdda7a3c3340", async() => {
                BeginContext(134, 1002, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""renderer"" content=""webkit|ie-comp|ie-stand"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width,initial-scale=1,minimum-scale=1.0,maximum-scale=1.0,user-scalable=no"" />
    <meta http-equiv=""Cache-Control"" content=""no-siteapp"" />
    <!--[if lt IE 9]>
    <script type=""text/javascript"" src=""/admin/js/html5.js""></script>
    <script type=""text/javascript"" src=""/admin/js/respond.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/PIE_IE678.js""></script>
    <![endif]-->
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/css/H-ui.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/css/H-ui.admin.css"" />
    <link type=""text/css"" rel=""stylesheet"" href=""/admin/font/font-awesome.min.css"" />
    <!--[if IE 7]>
    <link href=""/admin/font/font-awesome-ie7.min.css"" rel=""stylesheet"" type=""text/css"" />
    <![endif]-->
    <title>添加新闻类别</title>
");
                EndContext();
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
            EndContext();
            BeginContext(1143, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1145, 2728, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a0bcee770ed528e4068dc8a882b329dfdda7a3c5580", async() => {
                BeginContext(1151, 183, true);
                WriteLiteral("\r\n    <div class=\"pd-20\">\r\n        <div class=\"Huiform\">\r\n            <form method=\"post\" id=\"editForm\">\r\n                <table class=\"table table-bg\">\r\n                    <tbody>\r\n");
                EndContext();
#line 33 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
                         if (Model.code == 200)
                        {

#line default
#line hidden
                BeginContext(1410, 191, true);
                WriteLiteral("                            <tr>\r\n                                <th class=\"text-r\">类别名编号：</th>\r\n                                <td><input type=\"text\" style=\"width:300px\" class=\"input-text\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1601, "\"", 1623, 1);
#line 37 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
WriteAttributeValue("", 1609, Model.data.Id, 1609, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1624, 275, true);
                WriteLiteral(@" placeholder="""" id=""Id"" name=""Id"" readonly></td>
                            </tr>
                            <tr>
                                <th class=""text-r"">类别名称：</th>
                                <td><input type=""text"" style=""width:300px"" class=""input-text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1899, "\"", 1923, 1);
#line 41 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
WriteAttributeValue("", 1907, Model.data.Name, 1907, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1924, 305, true);
                WriteLiteral(@" placeholder="""" id=""name"" name=""name"" datatype=""*2-120"" nullmsg=""类别名称不能为空""></td>
                            </tr>
                            <tr>
                                <th class=""text-r"">排序：</th>
                                <td><input type=""text"" style=""width:300px"" class=""input-text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2229, "\"", 2253, 1);
#line 45 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
WriteAttributeValue("", 2237, Model.data.Sort, 2237, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2254, 268, true);
                WriteLiteral(@" placeholder="""" id=""sort"" name=""sort""></td>
                            </tr>
                            <tr>
                                <th class=""text-r"">备注：</th>
                                <td><input type=""text"" style=""width:300px"" class=""input-text""");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2522, "\"", 2548, 1);
#line 49 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
WriteAttributeValue("", 2530, Model.data.Remark, 2530, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2549, 344, true);
                WriteLiteral(@" placeholder="""" id=""remark"" name=""remark""></td>
                            </tr>
                            <tr>
                                <th></th>
                                <td><button class=""btn btn-success radius"" type=""button"" onclick=""edit()""><i class=""icon-ok""></i> 确定</button></td>
                            </tr>
");
                EndContext();
#line 55 "E:\Git\NewsPublish\NewsPublish.Web\Areas\Admin\Views\News\NewsClassifyEdit.cshtml"
                        }

#line default
#line hidden
                BeginContext(2920, 946, true);
                WriteLiteral(@"                    </tbody>
                </table>
            </form>
        </div>
    </div>
    <script type=""text/javascript"" src=""/admin/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/Validform_v5.3.2_min.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.js""></script>
    <script type=""text/javascript"" src=""/admin/js/H-ui.admin.js""></script>
    <script type=""text/javascript"">
    $("".Huiform"").Validform();
    function edit() {
        $.ajax({
            type: 'post',
            async: true,
            url: '/Admin/News/NewsClassifyEdit',
            data: $(""#editForm"").serialize(),
            success: function (data) {
                if (data.code == 200) {
                    parent.reload();
                }
                else {
                    alert(data.result);
                }
            }
        })
    }
    </script>

");
                EndContext();
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
            EndContext();
            BeginContext(3873, 13, true);
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NewsPublish.Model.Response.ResponseModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
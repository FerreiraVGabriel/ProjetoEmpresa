#pragma checksum "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27a2cca7aac6da3d0b19808f9a0ca4d96ef5af9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Edit), @"mvc.1.0.view", @"/Views/Home/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Edit.cshtml", typeof(AspNetCore.Views_Home_Edit))]
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
#line 1 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\_ViewImports.cshtml"
using ProjetoEmpresaStandBy2;

#line default
#line hidden
#line 2 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\_ViewImports.cshtml"
using ProjetoEmpresaStandBy2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27a2cca7aac6da3d0b19808f9a0ca4d96ef5af9d", @"/Views/Home/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5a034d30b26a66caffa190908007feae6936a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cliente>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/mask.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.maskMoney.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(17, 21, true);
            WriteLiteral("\r\n<h3>Editar</h3>\r\n\r\n");
            EndContext();
#line 5 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
 using (Html.BeginForm("Edit", "Home", FormMethod.Post, new { enctype = "multipart/form-data", id = "form-create" }))
{
    

#line default
#line hidden
            BeginContext(165, 23, false);
#line 7 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(195, 40, false);
#line 8 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
Write(Html.HiddenFor(model => model.ClienteId));

#line default
#line hidden
            EndContext();
            BeginContext(237, 285, true);
            WriteLiteral(@"    <div class=""panel panel-default"">
        <div class=""panel-body"">
            <div class=""col-md-4"">
                <div class=""form-group"">
                    <label class=""control-label label-cpt"">Razão Social<span style=""color:red""> *</span></label>
                    ");
            EndContext();
            BeginContext(523, 131, false);
#line 14 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.razao_social, new { htmlAttributes = new { @class = "form-control", placeholder = "Razão Social" } }));

#line default
#line hidden
            EndContext();
            BeginContext(654, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(677, 90, false);
#line 15 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.razao_social, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(767, 194, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label label-cpt\">CNPJ<span style=\"color:red\"> *</span></label>\r\n                    ");
            EndContext();
            BeginContext(962, 128, false);
#line 19 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.cnpj, new { htmlAttributes = new { @class = "form-control", placeholder = "CNPJ", id = "cnpj" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1090, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1113, 82, false);
#line 20 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.cnpj, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1195, 206, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label label-cpt\">Data de Fundação<span style=\"color:red\"> *</span></label>\r\n                    ");
            EndContext();
            BeginContext(1402, 136, false);
#line 24 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.data_fundacao, new { htmlAttributes = new { @class = "form-control", placeholder = "Data de Fundação" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1538, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1561, 91, false);
#line 25 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.data_fundacao, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1652, 222, true);
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n            <div class=\"col-md-4\">\r\n                <div class=\"form-group\">\r\n                    <label class=\"control-label label-cpt\">Capital</label>\r\n                    ");
            EndContext();
            BeginContext(1875, 121, false);
#line 32 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.EditorFor(model => model.capital, new { htmlAttributes = new { @class = "form-control", placeholder = "Capital" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1996, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2019, 85, false);
#line 33 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.capital, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2104, 265, true);
            WriteLiteral(@"
                </div>
                <div class=""form-group"">
                    <div class=""kt-radio-inline"">
                        <label class=""kt-radio kt-radio--bold kt-radio--success"" style=""font-size:14px !important;"">
                            ");
            EndContext();
            BeginContext(2370, 96, false);
#line 38 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
                       Write(Html.RadioButtonFor(model => model.status_cliente, true, new { @checked = "checked", id = "M" }));

#line default
#line hidden
            EndContext();
            BeginContext(2466, 231, true);
            WriteLiteral(" Ativo\r\n                            <span></span>\r\n                        </label>\r\n                        <label class=\"kt-radio kt-radio--bold kt-radio--success\" style=\"font-size:14px !important;\">\r\n                            ");
            EndContext();
            BeginContext(2698, 76, false);
#line 42 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
                       Write(Html.RadioButtonFor(model => model.status_cliente, false, new { @id = "F" }));

#line default
#line hidden
            EndContext();
            BeginContext(2774, 155, true);
            WriteLiteral(" Inativo\r\n                            <span></span>\r\n                        </label>\r\n                    </div>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(2930, 124, false);
#line 47 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
           Write(Html.EditorFor(model => model.classificacao, new { htmlAttributes = new { @id = "classificacao", style = "display:none" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3054, 457, true);
            WriteLiteral(@"
            </div>

            <div class=""col-md-4"">
                <div class=""form-group"">
                    <button type=""submit""
                            class=""btn btn-success"">
                        Editar Cliente
                    </button>
                </div>
            </div>
            <a onclick=""window.history.back()"" class=""btn btn-danger"" style=""color:#fff;""><span>Voltar</span></a>
        </div>
    </div>
");
            EndContext();
#line 61 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(3514, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fce852dacc0430bb25f13b0022e5f15", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3591, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3593, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4220f70591a443d69274aeac1b662192", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3657, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3659, 80, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "257fa499963049959181345dce0bbb00", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3739, 200, true);
            WriteLiteral("\r\n<script>\r\n    $(\"#cnpj\").inputmask(\"mask\", {\r\n        \"mask\": \"99.999.999/9999-99\"\r\n    });\r\n    $(\'#capital\').maskMoney({ showSymbol: true, symbol: \"R$\", decimal: \",\", thousands: \".\" });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
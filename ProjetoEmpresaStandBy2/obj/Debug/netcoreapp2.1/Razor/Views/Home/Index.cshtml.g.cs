#pragma checksum "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8de4e669f772a0cb9030af49b948236a8d1b082c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8de4e669f772a0cb9030af49b948236a8d1b082c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc5a034d30b26a66caffa190908007feae6936a5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Cliente>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
  
    /**/

    string razaoSocial = ViewBag.razaoSocial;
    string cnpj = ViewBag.cnpj;
    int status = ViewBag.status;

#line default
#line hidden
            BeginContext(158, 34, true);
            WriteLiteral("\r\n<div class=\"btnCliente\">\r\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 192, "\"", 220, 1);
#line 12 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 199, Url.Action("Create"), 199, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(221, 126, true);
            WriteLiteral(" class=\"btn btn-success\">\r\n        Novo Cliente\r\n    </a>\r\n</div>\r\n<div>\r\n    <fieldset>\r\n        <legend>Empresa</legend>\r\n\r\n");
            EndContext();
#line 20 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
         using (Html.BeginForm())
        {

#line default
#line hidden
            BeginContext(393, 260, true);
            WriteLiteral(@"            <p>
                <div class=""col-md-3"">
                    <label class=""control-label label-cpt"">Razão Social</label>
                    <input type=""text"" class=""form-control"" id=""razaoSocial"" name=""razaoSocial"" placeholder=""Razão Social""");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 653, "\"", 673, 1);
#line 25 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 661, razaoSocial, 661, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(674, 240, true);
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-3\">\r\n                    <label class=\"control-label label-cpt\">CNPJ</label>\r\n                    <input type=\"text\" class=\"form-control\" id=\"cnpj\" name=\"cnpj\" placeholder=\"CNPJ\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 914, "\"", 927, 1);
#line 29 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 922, cnpj, 922, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(928, 144, true);
            WriteLiteral(">\r\n                </div>\r\n                <div class=\"col-md-3\" style=\"padding-top:30px;\">\r\n                    <div class=\"kt-radio-inline\">\r\n");
            EndContext();
#line 33 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                         if (status == 1)
                        {

#line default
#line hidden
            BeginContext(1142, 337, true);
            WriteLiteral(@"                            <input type=""radio"" id=""Ativo"" name=""status"" value=1 checked>
                            <label style=""padding-right: 18px;"" for=""Ativo"">Ativo</label>
                            <input type=""radio"" id=""Inativo"" name=""status"" value=0>
                            <label for=""Inativo"">Inativo</label><br>
");
            EndContext();
#line 39 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(1563, 337, true);
            WriteLiteral(@"                            <input type=""radio"" id=""Ativo"" name=""status"" value=1>
                            <label style=""padding-right: 18px;"" for=""Ativo"">Ativo</label>
                            <input type=""radio"" id=""Inativo"" name=""status"" value=0 checked>
                            <label for=""Inativo"">Inativo</label><br>
");
            EndContext();
#line 46 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1927, 324, true);
            WriteLiteral(@"
                        <span></span>
                    </div>
                </div>
                <div class=""col-md-3"" style=""padding-top:30px;"">
                    <input class=""btn btn-success"" type=""submit"" value=""Pesquisar"" />
                    <input class=""btn btn-danger"" type=""button"" value=""Limpar""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 2251, "\"", 2306, 3);
            WriteAttributeValue("", 2261, "location.href=\'", 2261, 15, true);
#line 53 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 2276, Url.Action("Limpar", "Home"), 2276, 29, false);

#line default
#line hidden
            WriteAttributeValue("", 2305, "\'", 2305, 1, true);
            EndWriteAttribute();
            BeginContext(2307, 47, true);
            WriteLiteral(" />\r\n                </div>\r\n            </p>\r\n");
            EndContext();
#line 56 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2365, 682, true);
            WriteLiteral(@"    </fieldset>
    <fieldset>
        <legend>Clientes</legend>

        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Razão Social</th>
                    <th scope=""col"">Data de Fundação</th>
                    <th scope=""col"">CNPJ</th>
                    <th scope=""col"">Capital</th>
                    <th scope=""col"">Quarentena</th>
                    <th scope=""col"">Cliente Status</th>
                    <th scope=""col"">Classificação</th>
                    <th scope=""col"">Opções</th>

                </tr>
            </thead>
            <tbody>
");
            EndContext();
#line 77 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(3112, 66, true);
            WriteLiteral("                    <tr>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(3179, 14, false);
#line 80 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                   Write(item.ClienteId);

#line default
#line hidden
            EndContext();
            BeginContext(3193, 47, true);
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(3241, 17, false);
#line 81 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                   Write(item.razao_social);

#line default
#line hidden
            EndContext();
            BeginContext(3258, 47, true);
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(3306, 41, false);
#line 82 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                   Write(item.data_fundacao.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3347, 47, true);
            WriteLiteral("</th>\r\n                        <th scope=\"row\">");
            EndContext();
            BeginContext(3395, 9, false);
#line 83 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                   Write(item.cnpj);

#line default
#line hidden
            EndContext();
            BeginContext(3404, 50, true);
            WriteLiteral("</th>\r\n                        <th scope=\"row\">R$ ");
            EndContext();
            BeginContext(3455, 12, false);
#line 84 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                      Write(item.capital);

#line default
#line hidden
            EndContext();
            BeginContext(3467, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
#line 85 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                         if (item.quarentena == true)
                        {

#line default
#line hidden
            BeginContext(3556, 56, true);
            WriteLiteral("                            <th scope=\"row\">Ativo</th>\r\n");
            EndContext();
#line 88 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(3696, 59, true);
            WriteLiteral("                            <th scope=\"row\">Desativo</th>\r\n");
            EndContext();
#line 92 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3782, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 93 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                         if (item.status_cliente == true)
                        {

#line default
#line hidden
            BeginContext(3868, 56, true);
            WriteLiteral("                            <th scope=\"row\">Ativo</th>\r\n");
            EndContext();
#line 96 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
            BeginContext(4008, 59, true);
            WriteLiteral("                            <th scope=\"row\">Desativo</th>\r\n");
            EndContext();
#line 100 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(4094, 40, true);
            WriteLiteral("                        <th scope=\"row\">");
            EndContext();
            BeginContext(4135, 18, false);
#line 101 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                                   Write(item.classificacao);

#line default
#line hidden
            EndContext();
            BeginContext(4153, 91, true);
            WriteLiteral("</th>\r\n\r\n\r\n                        <td>\r\n                            <a href=\"javascript:;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 4244, "\"", 4285, 3);
            WriteAttributeValue("", 4254, "DeletarCliente(", 4254, 15, true);
#line 105 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 4269, item.ClienteId, 4269, 15, false);

#line default
#line hidden
            WriteAttributeValue("", 4284, ")", 4284, 1, true);
            EndWriteAttribute();
            BeginContext(4286, 842, true);
            WriteLiteral(@" data-toggle=""modal"" data-target=""#exampleModal"" title=""Editar"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-trash"" viewBox=""0 0 16 16"">
                                    <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                                    <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
                                </svg>
                            </a>
                            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5128, "\"", 5190, 1);
#line 111 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
WriteAttributeValue("", 5135, Url.Action("Edit", new { ClienteId = item.ClienteId }), 5135, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5191, 816, true);
            WriteLiteral(@"
                               data-toggle=""tooltip"" title=""Editar"">
                                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-pencil"" viewBox=""0 0 16 16"">
                                    <path d=""M12.146.146a.5.5 0 0 1 .708 0l3 3a.5.5 0 0 1 0 .708l-10 10a.5.5 0 0 1-.168.11l-5 2a.5.5 0 0 1-.65-.65l2-5a.5.5 0 0 1 .11-.168l10-10zM11.207 2.5L13.5 4.793 14.793 3.5 12.5 1.207 11.207 2.5zm1.586 3L10.5 3.207 4 9.707V10h.5a.5.5 0 0 1 .5.5v.5h.5a.5.5 0 0 1 .5.5v.5h.293l6.5-6.5zm-9.761 5.175l-.106.106-1.528 3.821 3.821-1.528.106-.106A.5.5 0 0 1 5 12.5V12h-.5a.5.5 0 0 1-.5-.5V11h-.5a.5.5 0 0 1-.468-.325z"" />
                                </svg>
                            </a>
                        </td>
                    </tr>
");
            EndContext();
#line 119 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(6026, 839, true);
            WriteLiteral(@"            </tbody>
        </table>
    </fieldset>

    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Deletar Cliente</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div class=""modal-body"">
                    Tem Certeza que deseja remover o Cliente selecionado?
                </div>
                <div class=""modal-footer"">
");
            EndContext();
#line 138 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                     using (Html.BeginForm("Delete", "Home"))
                    {

#line default
#line hidden
            BeginContext(6951, 310, true);
            WriteLiteral(@"                        <input class=""form-control col-md-6 "" type=""hidden"" name=""idClienteDelete"" id=""idClienteDelete"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Não</button>
                        <button type=""submit"" class=""btn btn-success"">Sim</button>
");
            EndContext();
#line 143 "C:\ESTUDOS\ProjetoEmpresaStandBy\ProjetoEmpresaStandBy2\ProjetoEmpresaStandBy2\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(7284, 82, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(7366, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "156fbdefa0354bbb95a24fe25bb6dea5", async() => {
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
            BeginContext(7443, 173, true);
            WriteLiteral("\r\n<script>\r\n    function DeletarCliente(clienteId) {\r\n        $(\"#idClienteDelete\").val(clienteId);\r\n        var x = $(\"#idClienteDelete\").val();\r\n    }\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Cliente>> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10bf858ade278c2d13e4e0222eef9ede135e0ab6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsersList_ShowBuyProducts), @"mvc.1.0.view", @"/Views/UsersList/ShowBuyProducts.cshtml")]
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
#line 1 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\_ViewImports.cshtml"
using Electronics_Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\_ViewImports.cshtml"
using Electronics_Shop.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\_ViewImports.cshtml"
using Electronics_Shop.Models.Product;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\_ViewImports.cshtml"
using Electronics_Shop.Models.User;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10bf858ade278c2d13e4e0222eef9ede135e0ab6", @"/Views/UsersList/ShowBuyProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b05a4d894b35ab89ee223cfbbe4dc2ad876c3a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UsersList_ShowBuyProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BuyProduct>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success ml-2 w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UsersList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateBuyProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeUserBuyProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUserBuyProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10bf858ade278c2d13e4e0222eef9ede135e0ab66040", async() => {
                WriteLiteral("Добавить продукт");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 5 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"

    if(Model.Count() == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h1 class=\"text-secondary display-5 m-2\">У пользователя нету покупок</h1>\r\n");
#nullable restore
#line 8 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
    }
    else{
        foreach (var u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row shadow mb-4 bg-body rounded\" name=\"main\">\r\n                <div class=\"col-lg-2\">\r\n                    <img class=\"img-thumbnail m-3\"");
            BeginWriteAttribute("src", " src=\"", 504, "\"", 518, 1);
#nullable restore
#line 14 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
WriteAttributeValue("", 510, u.Image, 510, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Изображение отсутсвует\" />\r\n                </div>\r\n\r\n                <div class=\"col m-3\" name=\"divSecond\">\r\n                    <p>Логин покупателя: ");
#nullable restore
#line 18 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
                                    Write(u.Users.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Товар: ");
#nullable restore
#line 19 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
                         Write(u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Цена: ");
#nullable restore
#line 20 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
                        Write(u.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p>Дата покупки: ");
#nullable restore
#line 21 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
                                Write(u.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                    <div name=\"divThird\">\r\n                        <div name=\"needHide\"");
            BeginWriteAttribute("id", " id=\"", 921, "\"", 931, 1);
#nullable restore
#line 24 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
WriteAttributeValue("", 926, u.Id, 926, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <p><a class=\"btn btn-outline-success mr-3\">Редактировать</a></p>\r\n                        </div>\r\n\r\n                        <div class=\"needHideFirst\" name=\"needShow\">\r\n                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10bf858ade278c2d13e4e0222eef9ede135e0ab610709", async() => {
                WriteLiteral("Изменить покупку");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                            <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "10bf858ade278c2d13e4e0222eef9ede135e0ab612199", async() => {
                WriteLiteral("Удалить покупку");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(\'div[name=\"main\"]\').children(\'div[name=\"divSecond\"]\').children(\'div[name=\"divThird\"]\').children(\'div[name=\"needHide\"]\').click(function () {\r\n\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 43 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ShowBuyProducts.cshtml"
             Write(Url.Action("GetIdProductUser", "UsersList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            contentType: ""application/json; charset=utf-8"",
            data: { idProductUser: $(this).attr('id') },
            dataType: ""json"",
            success: SuccessShopCart,
            error: AjaxError
        })

        $('div[name=""main""]').children('div[name=""divSecond""]').children('div[name=""divThird""]').children('div[name=""needHide""]').show();
        $('div[name=""needShow""]').hide();

        $(this).parent().children('div[name=""needShow""]').show();
        $(this).hide();
    })

    function SuccessShopCart(data) {
        console.log(data);
    }

    function AjaxError() {
        $(""body"").overhang({
            type: ""error"",
            message: ""Что-то пошло не так..."",
            closeConfirm: true
        });
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BuyProduct>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

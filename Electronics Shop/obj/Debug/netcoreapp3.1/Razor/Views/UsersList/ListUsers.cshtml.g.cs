#pragma checksum "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c0ba7eb52e4f2ad447d87e63df0f933059f76d78"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UsersList_ListUsers), @"mvc.1.0.view", @"/Views/UsersList/ListUsers.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0ba7eb52e4f2ad447d87e63df0f933059f76d78", @"/Views/UsersList/ListUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b05a4d894b35ab89ee223cfbbe4dc2ad876c3a1", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UsersList_ListUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Users>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "UsersList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowBuyProducts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ChangeUserSettings", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger mr-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <h1 class=\"display-4\">Пользователи</h1>\r\n    <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ba7eb52e4f2ad447d87e63df0f933059f76d786709", async() => {
                WriteLiteral("Создать пользователя");
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
#line 6 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
    foreach (var u in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row shadow mb-4 bg-body rounded\" name=\"main\">\r\n        <div class=\"col-lg-2 mt-3\">\r\n            <img class=\"img-thumbnail mt-4 ml-3 d-block rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 407, "\"", 421, 1);
#nullable restore
#line 10 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
WriteAttributeValue("", 413, u.Image, 413, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Изображение отсутсвует\" />\r\n        </div>\r\n\r\n        <div class=\"col m-3\" name=\"divSecond\">\r\n\r\n");
#nullable restore
#line 15 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
              
                if(@u.Status == "Adm")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p class=\"text-danger\">Администратор</p>\r\n");
#nullable restore
#line 19 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>Логин пользователя: ");
#nullable restore
#line 21 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
                              Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>ФИО: ");
#nullable restore
#line 22 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
               Write(u.FIO);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>Телефон: ");
#nullable restore
#line 23 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
                   Write(u.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>EMail: ");
#nullable restore
#line 24 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
                 Write(u.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n");
#nullable restore
#line 26 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
              
                if(@u.Status == "User"){

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div name=\"needHide\"");
            BeginWriteAttribute("id", " id=\"", 946, "\"", 956, 1);
#nullable restore
#line 28 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
WriteAttributeValue("", 951, u.Id, 951, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <p><a class=\"btn btn-outline-success mr-3\">Редактировать</a></p>\r\n                    </div>\r\n");
            WriteLiteral("                    <div class=\"needHideFirst\" name=\"needShow\">\r\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ba7eb52e4f2ad447d87e63df0f933059f76d7811715", async() => {
                WriteLiteral("Список покупок пользователя");
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
            WriteLiteral("</p>\r\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ba7eb52e4f2ad447d87e63df0f933059f76d7813212", async() => {
                WriteLiteral("Изменить данные пользователя");
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
            WriteLiteral("</p>\r\n                        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c0ba7eb52e4f2ad447d87e63df0f933059f76d7814710", async() => {
                WriteLiteral("Удалить пользователя");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n                    </div>\r\n");
#nullable restore
#line 37 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
#nullable restore
#line 41 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script>\r\n    $(\'div[name=\"main\"]\').children(\'div[name=\"divSecond\"]\').children(\'div[name=\"needHide\"]\').click(function () {\r\n\r\n        $.ajax({\r\n            url: \'");
#nullable restore
#line 48 "D:\Курсовая ощепков\Electronics Shop(Desktop)\Electronics Shop\Views\UsersList\ListUsers.cshtml"
             Write(Url.Action("GetIdUser", "UsersList"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            contentType: ""application/json; charset=utf-8"",
            data: { idUser: $(this).attr('id') },
            dataType: ""json"",
            success: SuccessShopCart,
            error: AjaxError
        })

        $('div[name=""main""]').children('div[name=""divSecond""]').children('div[name=""needHide""]').show();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Users>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591

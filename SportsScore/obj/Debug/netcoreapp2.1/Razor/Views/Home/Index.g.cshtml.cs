#pragma checksum "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa585ddaab6ac8e5a6fc115f8e4957b38016a5d8"
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
#line 1 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\_ViewImports.cshtml"
using SportsScore;

#line default
#line hidden
#line 2 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\_ViewImports.cshtml"
using SportsScore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa585ddaab6ac8e5a6fc115f8e4957b38016a5d8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbf476dc5db8a82f90365bd3f2baa134413f209d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SportsScore.Models.ProductsList>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:flex;justify-content:space-between;align-items:baseline; margin-bottom: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color: red; cursor: pointer; margin-left: 5px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("page-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

    string nameSort = ViewData["CurrentSortParam"].ToString();
    string priceSort = ViewData["CurrentSortParam"].ToString();

#line default
#line hidden
            BeginContext(214, 1278, true);
            WriteLiteral(@"
<h2>Products</h2>
<hr />
<style>
    .pagination {
        display: flex;
        justify-content: center;
    }

    .page {
        display: flex;
        justify-content: center;
        align-items: center;
        background: #ccc;
        width: 20px;
        height: 20px;
        min-width: 20px;
        margin: 0 10px;
        border-radius: 5px;
        cursor: pointer;
    }

    .page-item.disabled {
        pointer-events: none;
    }

    /*.list{
        padding:20px;
        display:grid;
        grid-template-columns: 1fr 1fr 1fr;
        grid-gap: 20px;
        background-color:aliceblue;*/
    }

    .card-holder {
        width: 100%;
        overflow: hidden;
        display: flex;
        flex-direction: column;
        background-color: white;
        border-radius: 10px;
    }

    .img-holder {
        width: 100%;
    }

    .text-holder {
        padding: 10px;
    }

    .price {
        display: flex;
        text-align: center;");
            WriteLiteral("\r\n        justify-content: space-between;\r\n    }\r\n\r\n    .add-to-cart {\r\n        border-radius: 20px;\r\n        border: none;\r\n        padding: 10px;\r\n        min-width: 40%;\r\n        color: white;\r\n        background-color: dodgerblue\r\n    }\r\n</style>\r\n\r\n");
            EndContext();
            BeginContext(1492, 496, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a84ad646f864703a6458441c71e8da6", async() => {
                BeginContext(1631, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1637, 40, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c883b6e0413a4265b81c34a3467b5d0e", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 77 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1677, 304, true);
                WriteLiteral(@"
    <p>Name:</p>
    <input name=""Name"" type=""text"" />
    <p>Price:</p>
    <input name=""Price"" type=""number"" />
    <p>Description:</p>
    <input name=""desc"" type=""text"" />
    <p>Category:</p>
    <input name=""Category"" type=""text"" />
    <br />
    <button type=""submit"">Submit</button>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1988, 128, true);
            WriteLiteral("\r\n\r\n<div class=\"list\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2116, 542, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17ebb68752064379bc2d8be2b074590b", async() => {
                BeginContext(2186, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 96 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                         if (nameSort == "name")
                        {

#line default
#line hidden
                BeginContext(2265, 49, true);
                WriteLiteral("                            <span>Name ↑</span>\r\n");
                EndContext();
#line 99 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }
                        else if (nameSort == "name_desc")
                        {

#line default
#line hidden
                BeginContext(2427, 49, true);
                WriteLiteral("                            <span>Name ↓</span>\r\n");
                EndContext();
#line 103 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2560, 47, true);
                WriteLiteral("                            <span>Name</span>\r\n");
                EndContext();
#line 107 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(2634, 20, true);
                WriteLiteral("                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 95 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                   WriteLiteral(ViewData["NameSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2658, 145, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Description\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(2803, 550, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0d2a512c8ff4197847efa417fc3b8bf", async() => {
                BeginContext(2874, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 115 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                         if (priceSort == "price")
                        {

#line default
#line hidden
                BeginContext(2955, 50, true);
                WriteLiteral("                            <span>Price ↑</span>\r\n");
                EndContext();
#line 118 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }
                        else if (priceSort == "price_desc")
                        {

#line default
#line hidden
                BeginContext(3120, 50, true);
                WriteLiteral("                            <span>Price ↓</span>\r\n");
                EndContext();
#line 122 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(3254, 48, true);
                WriteLiteral("                            <span>Price</span>\r\n");
                EndContext();
#line 126 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
                BeginContext(3329, 20, true);
                WriteLiteral("                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-sortOrder", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 114 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                   WriteLiteral(ViewData["PriceSortParm"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3353, 126, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
            EndContext();
#line 135 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
             foreach (var item in Model.Products)
            {

#line default
#line hidden
            BeginContext(3545, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3618, 39, false);
#line 139 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(3657, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3737, 46, false);
#line 142 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(3783, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(3863, 40, false);
#line 145 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
            EndContext();
            BeginContext(3903, 67, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"row\">\r\n");
            EndContext();
            BeginContext(4104, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(4128, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "271a484f363a4c7aac387fe8655e17c9", async() => {
                BeginContext(4237, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 149 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                 WriteLiteral(item.ProductID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4247, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 152 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4314, 42, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n");
            EndContext();
#line 157 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
  
    double pageCount = Math.Ceiling((double)Model.TotalCount / Model.PageSize);


#line default
#line hidden
            BeginContext(4443, 40, true);
            WriteLiteral("    <ul class=\"pagination\">\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4483, "\"", 4549, 2);
            WriteAttributeValue("", 4491, "page-item", 4491, 9, true);
#line 161 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4500, Model.CurrentPageIndex == 0 ? "disabled" : "", 4501, 48, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4550, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(4565, 196, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00c1e088b4774d10947589e891719888", async() => {
                BeginContext(4749, 8, true);
                WriteLiteral("Previous");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 162 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                          WriteLiteral(Math.Max(Model.CurrentPageIndex - 1, 0));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 162 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                                                                                         WriteLiteral(ViewData["CurrentSortParam"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4761, 19, true);
            WriteLiteral("\r\n        </li>\r\n\r\n");
            EndContext();
#line 165 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
         for (int i = 0; i < pageCount; i++)
        {


#line default
#line hidden
            BeginContext(4839, 15, true);
            WriteLiteral("            <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 4854, "\"", 4918, 2);
            WriteAttributeValue("", 4862, "page-item", 4862, 9, true);
#line 168 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 4871, Model.CurrentPageIndex == i ? "active" : "", 4872, 46, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4919, 19, true);
            WriteLiteral(">\r\n                ");
            EndContext();
            BeginContext(4938, 158, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "dbbf314cebe54ec4b61b14192e2a68cf", async() => {
                BeginContext(5086, 5, false);
#line 169 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                                                                                              Write(i + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 169 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                              WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 169 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                                                       WriteLiteral(ViewData["CurrentSortParam"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5096, 21, true);
            WriteLiteral("\r\n            </li>\r\n");
            EndContext();
#line 171 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(5128, 13, true);
            WriteLiteral("\r\n        <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 5141, "\"", 5219, 2);
            WriteAttributeValue("", 5149, "page-item", 5149, 9, true);
#line 173 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 5158, Model.CurrentPageIndex == pageCount - 1 ? "disabled" : "", 5159, 60, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5220, 15, true);
            WriteLiteral(">\r\n            ");
            EndContext();
            BeginContext(5235, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91f947edcc8c46f29fdeec0703be615c", async() => {
                BeginContext(5431, 4, true);
                WriteLiteral("Next");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-currentPageIndex", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 174 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                          WriteLiteral(Math.Min(Model.CurrentPageIndex + 1, pageCount - 1));

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-currentPageIndex", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["currentPageIndex"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 174 "C:\Users\ladob\Desktop\LadoKakhashvili\LadoKakhashvili\SportsScore\SportsScore\Views\Home\Index.cshtml"
                                                                                                                                                                     WriteLiteral(ViewData["CurrentSortParam"]);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-sortOrder", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["sortOrder"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5439, 28, true);
            WriteLiteral("\r\n        </li>\r\n    </ul>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SportsScore.Models.ProductsList> Html { get; private set; }
    }
}
#pragma warning restore 1591
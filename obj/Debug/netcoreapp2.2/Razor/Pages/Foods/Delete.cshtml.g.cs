#pragma checksum "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e83b724d58d82df9dd42f80c6503204cf8eca11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KetoCalculator.Pages.Foods.Pages_Foods_Delete), @"mvc.1.0.razor-page", @"/Pages/Foods/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Foods/Delete.cshtml", typeof(KetoCalculator.Pages.Foods.Pages_Foods_Delete), null)]
namespace KetoCalculator.Pages.Foods
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\_ViewImports.cshtml"
using KetoCalculator;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e83b724d58d82df9dd42f80c6503204cf8eca11", @"/Pages/Foods/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c640aacb52fe891ad036cd407067df9c4fde4ed", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Foods_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(98, 177, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>FoodStuff</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(276, 54, false);
#line 16 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(330, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(392, 50, false);
#line 19 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(442, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(503, 59, false);
#line 22 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.ProteinPer100));

#line default
#line hidden
            EndContext();
            BeginContext(562, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(624, 55, false);
#line 25 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.ProteinPer100));

#line default
#line hidden
            EndContext();
            BeginContext(679, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(740, 55, false);
#line 28 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.FatPer100));

#line default
#line hidden
            EndContext();
            BeginContext(795, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(857, 51, false);
#line 31 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.FatPer100));

#line default
#line hidden
            EndContext();
            BeginContext(908, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(969, 56, false);
#line 34 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.CarbPer100));

#line default
#line hidden
            EndContext();
            BeginContext(1025, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1087, 52, false);
#line 37 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.CarbPer100));

#line default
#line hidden
            EndContext();
            BeginContext(1139, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1200, 60, false);
#line 40 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.UpdateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1260, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1322, 56, false);
#line 43 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.UpdateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1378, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1439, 55, false);
#line 46 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FoodStuff.FoodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1556, 65, false);
#line 49 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FoodStuff.FoodGroup.FoodGroupName));

#line default
#line hidden
            EndContext();
            BeginContext(1621, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1659, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e83b724d58d82df9dd42f80c6503204cf8eca1110443", async() => {
                BeginContext(1679, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1689, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "0e83b724d58d82df9dd42f80c6503204cf8eca1110836", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 54 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.FoodStuff.FoodId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1739, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1822, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0e83b724d58d82df9dd42f80c6503204cf8eca1112770", async() => {
                    BeginContext(1844, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1860, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1873, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KetoCalculator.Pages.Foods.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.Foods.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.Foods.DeleteModel>)PageContext?.ViewData;
        public KetoCalculator.Pages.Foods.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

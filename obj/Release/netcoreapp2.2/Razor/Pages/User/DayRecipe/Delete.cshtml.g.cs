#pragma checksum "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2ca17c576a8b25e4cbfe13a65a6e19ae7cd21b9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KetoCalculator.Pages.User.DayRecipe.Pages_User_DayRecipe_Delete), @"mvc.1.0.razor-page", @"/Pages/User/DayRecipe/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/User/DayRecipe/Delete.cshtml", typeof(KetoCalculator.Pages.User.DayRecipe.Pages_User_DayRecipe_Delete), null)]
namespace KetoCalculator.Pages.User.DayRecipe
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
#line 3 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\_ViewImports.cshtml"
using KetoCalculator.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2ca17c576a8b25e4cbfe13a65a6e19ae7cd21b9", @"/Pages/User/DayRecipe/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d75f32c354958fc01a20dc4e9b7e71aa7e43af6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_User_DayRecipe_Delete : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
            BeginContext(63, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(107, 175, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Recipes</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(283, 54, false);
#line 16 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recipes.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(337, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(399, 50, false);
#line 19 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recipes.RecipeName));

#line default
#line hidden
            EndContext();
            BeginContext(449, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(510, 55, false);
#line 22 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recipes.RecipieUser));

#line default
#line hidden
            EndContext();
            BeginContext(565, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(627, 51, false);
#line 25 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recipes.RecipieUser));

#line default
#line hidden
            EndContext();
            BeginContext(678, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(739, 52, false);
#line 28 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recipes.Calories));

#line default
#line hidden
            EndContext();
            BeginContext(791, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(853, 48, false);
#line 31 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recipes.Calories));

#line default
#line hidden
            EndContext();
            BeginContext(901, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(962, 49, false);
#line 34 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recipes.Ratio));

#line default
#line hidden
            EndContext();
            BeginContext(1011, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1073, 45, false);
#line 37 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recipes.Ratio));

#line default
#line hidden
            EndContext();
            BeginContext(1118, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1179, 58, false);
#line 40 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Recipes.UpdateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1237, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1299, 54, false);
#line 43 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Recipes.UpdateDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1353, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1391, 214, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ca17c576a8b25e4cbfe13a65a6e19ae7cd21b99854", async() => {
                BeginContext(1411, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1421, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b2ca17c576a8b25e4cbfe13a65a6e19ae7cd21b910246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 48 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\User\DayRecipe\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Recipes.RecipeId);

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
                BeginContext(1471, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1554, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2ca17c576a8b25e4cbfe13a65a6e19ae7cd21b912189", async() => {
                    BeginContext(1576, 12, true);
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
                BeginContext(1592, 6, true);
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
            BeginContext(1605, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KetoCalculator.Pages.User.DayRecipe.DeleteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.User.DayRecipe.DeleteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.User.DayRecipe.DeleteModel>)PageContext?.ViewData;
        public KetoCalculator.Pages.User.DayRecipe.DeleteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
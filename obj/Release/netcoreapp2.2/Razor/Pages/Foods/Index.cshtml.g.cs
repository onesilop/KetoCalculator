#pragma checksum "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52aa7140ff887dc7ee470612b08b0954599bde34"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KetoCalculator.Pages.Foods.Pages_Foods_Index), @"mvc.1.0.razor-page", @"/Pages/Foods/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Foods/Index.cshtml", typeof(KetoCalculator.Pages.Foods.Pages_Foods_Index), null)]
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
#line 3 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\_ViewImports.cshtml"
using KetoCalculator.Data;

#line default
#line hidden
#line 3 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
using KetoCalculator.Areas.Identity.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52aa7140ff887dc7ee470612b08b0954599bde34", @"/Pages/Foods/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d75f32c354958fc01a20dc4e9b7e71aa7e43af6", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Foods_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(200, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(243, 25, true);
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n");
            EndContext();
#line 14 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(317, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(325, 35, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52aa7140ff887dc7ee470612b08b0954599bde345131", async() => {
                BeginContext(346, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(360, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(369, 90, true);
            WriteLiteral("</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(460, 58, false);
#line 23 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].FoodGroup));

#line default
#line hidden
            EndContext();
            BeginContext(518, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(574, 57, false);
#line 26 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].FoodName));

#line default
#line hidden
            EndContext();
            BeginContext(631, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(687, 62, false);
#line 29 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].ProteinPer100));

#line default
#line hidden
            EndContext();
            BeginContext(749, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(805, 58, false);
#line 32 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].FatPer100));

#line default
#line hidden
            EndContext();
            BeginContext(863, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(919, 59, false);
#line 35 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].CarbPer100));

#line default
#line hidden
            EndContext();
            BeginContext(978, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1034, 57, false);
#line 38 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].Calories));

#line default
#line hidden
            EndContext();
            BeginContext(1091, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1147, 54, false);
#line 41 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FoodStuff[0].Ratio));

#line default
#line hidden
            EndContext();
            BeginContext(1201, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 47 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
         foreach (var item in Model.FoodStuff)
        {

#line default
#line hidden
            BeginContext(1346, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1407, 58, false);
#line 51 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FoodGroup.FoodGroupName));

#line default
#line hidden
            EndContext();
            BeginContext(1465, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 54 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
            BeginContext(1593, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(1617, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52aa7140ff887dc7ee470612b08b0954599bde3411157", async() => {
                BeginContext(1667, 43, false);
#line 56 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                                                                    Write(Html.DisplayFor(modelItem => item.FoodName));

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                                               WriteLiteral(item.FoodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1714, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 57 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
            BeginContext(1813, 43, false);
#line 60 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.FoodName));

#line default
#line hidden
            EndContext();
#line 60 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                                                                    
                    }

#line default
#line hidden
            BeginContext(1881, 67, true);
            WriteLiteral("                </td>\r\n\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1949, 48, false);
#line 65 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProteinPer100));

#line default
#line hidden
            EndContext();
            BeginContext(1997, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2065, 44, false);
#line 68 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.FatPer100));

#line default
#line hidden
            EndContext();
            BeginContext(2109, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2177, 45, false);
#line 71 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CarbPer100));

#line default
#line hidden
            EndContext();
            BeginContext(2222, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2290, 43, false);
#line 74 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Calories));

#line default
#line hidden
            EndContext();
            BeginContext(2333, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2401, 40, false);
#line 77 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ratio));

#line default
#line hidden
            EndContext();
            BeginContext(2441, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 80 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                     if (SignInManager.IsSignedIn(User))
                    {

#line default
#line hidden
            BeginContext(2569, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(2593, 61, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52aa7140ff887dc7ee470612b08b0954599bde3417215", async() => {
                BeginContext(2644, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 82 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                                                 WriteLiteral(item.FoodId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2654, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 83 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(2679, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 86 "C:\Users\a138768\OneDrive - AGL Energy\Projects\Code\KetoCalculator\Pages\Foods\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2732, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KetoCalculator.Pages.Foods.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.Foods.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KetoCalculator.Pages.Foods.IndexModel>)PageContext?.ViewData;
        public KetoCalculator.Pages.Foods.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

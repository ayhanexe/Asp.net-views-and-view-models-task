#pragma checksum "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f763c3fb40fce23a61dc0c5d763c17773604f936"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.views_Pharmacy_Drug), @"mvc.1.0.view", @"/views/Pharmacy/Drug.cshtml")]
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
#line 1 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
using aspnet_view_models.models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
using aspnet_view_models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f763c3fb40fce23a61dc0c5d763c17773604f936", @"/views/Pharmacy/Drug.cshtml")]
    public class views_Pharmacy_Drug : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PharmacyDrugViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
     foreach(var drug in Model.Drugs as List<Drug>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <span>Name: ");
#nullable restore
#line 9 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
                   Write(drug.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>Company: ");
#nullable restore
#line 10 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
                      Write(drug.Company);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n            <span>Price: ");
#nullable restore
#line 11 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
                    Write(drug.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n");
#nullable restore
#line 13 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n\r\n<ul>\r\n");
#nullable restore
#line 18 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
     foreach(var drugType in Model.DrugTypes as List<DrugType>)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <span>Type: ");
#nullable restore
#line 21 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
                   Write(drugType.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </li>\r\n");
#nullable restore
#line 23 "C:\Users\Aykhan\source\repos\Asp.net view models, layout views\Asp.net view models, layout views\views\Pharmacy\Drug.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PharmacyDrugViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

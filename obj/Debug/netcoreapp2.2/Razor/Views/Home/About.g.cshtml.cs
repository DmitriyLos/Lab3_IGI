#pragma checksum "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f45adbcd39312888d087b6998e0a60a2930ead31"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
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
#line 1 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\_ViewImports.cshtml"
using lab3;

#line default
#line hidden
#line 2 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\_ViewImports.cshtml"
using lab3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45adbcd39312888d087b6998e0a60a2930ead31", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f221d4f4fa292e12340e1c358a13d1b8ff796fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<lab3.ViewModels.HomeViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden
            BeginContext(79, 101, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <label>Сотрудники</label>\r\n        <table>\r\n");
            EndContext();
#line 10 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
              
                foreach (Employee i in Model.Employees)
                {

#line default
#line hidden
            BeginContext(272, 60, true);
            WriteLiteral("                       <tr>\r\n                           <td>");
            EndContext();
            BeginContext(333, 9, false);
#line 14 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                          Write(i.Surname);

#line default
#line hidden
            EndContext();
            BeginContext(342, 38, true);
            WriteLiteral("</td>\r\n                           <td>");
            EndContext();
            BeginContext(381, 6, false);
#line 15 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                          Write(i.Post);

#line default
#line hidden
            EndContext();
            BeginContext(387, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 17 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(459, 107, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <label>Клиенты</label>\r\n        <table>\r\n");
            EndContext();
#line 24 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
              
                foreach (Client i in Model.Clients)
                {

#line default
#line hidden
            BeginContext(654, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(709, 6, false);
#line 28 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(715, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(751, 7, false);
#line 29 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(758, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 31 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(826, 106, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <label>Услуги</label>\r\n        <table>\r\n");
            EndContext();
#line 38 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
              
                foreach (Service i in Model.Services)
                {

#line default
#line hidden
            BeginContext(1022, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1077, 6, false);
#line 42 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1083, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1119, 7, false);
#line 43 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 45 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1194, 106, true);
            WriteLiteral("        </table>\r\n    </div>\r\n    <div class=\"col-md-2\">\r\n        <label>Записи</label>\r\n        <table>\r\n");
            EndContext();
#line 52 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
              
                foreach (Appointment i in Model.Appointments)
                {

#line default
#line hidden
            BeginContext(1398, 54, true);
            WriteLiteral("                    <tr>\r\n                        <td>");
            EndContext();
            BeginContext(1453, 10, false);
#line 56 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Discount);

#line default
#line hidden
            EndContext();
            BeginContext(1463, 35, true);
            WriteLiteral("</td>\r\n                        <td>");
            EndContext();
            BeginContext(1499, 17, false);
#line 57 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                       Write(i.Date.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1516, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 59 "D:\учёба\6сем\ИГИЛ\lab3\lab3\Views\Home\About.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1584, 38, true);
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<lab3.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591

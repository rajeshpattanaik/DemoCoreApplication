#pragma checksum "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a86b215bd89b26307361c58afd5f938677558d96"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\_ViewImports.cshtml"
using NewCoreApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\_ViewImports.cshtml"
using NewCoreApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a86b215bd89b26307361c58afd5f938677558d96", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5bc2f07dc9298708f34988664409a1eb109270e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Feedback Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 5 "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\Home\Index.cshtml"
     using (Html.BeginForm("FormSubmit", "Home", FormMethod.Post, new { @class = "g-3 needs-validation" }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-form-label"">
            Feedback Form
        </div>
        <div class=""list"">
            <div class=""row"">
                <div class=""col"">
                    <label for=""formName"" class=""form-label"">Name : </label>
                    <input id=""formName"" name=""formName"" type=""text"" title=""formName"" class=""form-control"" maxlength=""20"" required />
                </div>
                <div class=""col"">
                    <label class=""form-label"">Email Address : </label>
                    <input id=""formEmail"" name=""formEmail"" type=""email"" title=""formName"" class=""form-control"" required />
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <label class=""form-label"">Is this your first visit to the website?</label>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formVisit"" title=""Yes"" value=""Yes"" class=""form-check-input"" id=""formYes"" />
   ");
            WriteLiteral(@"                     <label for=""formYes"" class=""form-check-label"">Yes</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formVisit"" title=""No"" value=""No"" class=""form-check-input"" id=""formNo"" />
                        <label for=""formNo"" class=""form-check-label"">No</label>
                    </div>
                </div>
                <div class=""col"">
                    <label class=""form-label"">Were you able to find what you need?</label>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formInfo"" title=""Yes"" value=""Yes"" class=""form-check-input"" id=""formYes"" />
                        <label for=""formYes"" class=""form-check-label"">Yes</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formInfo"" title=""No"" value=""No"" class=""form-check-input"" id=""formNo"" />
                        <label for");
            WriteLiteral(@"=""formNo"" class=""form-check-label"">No</label>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <span class=""rounded-circle"">What is the primary reason for your visit to the website? </span>
                    <textarea name=""formVisitReason"" class=""form-control"" maxlength=""200"" spellcheck=""true""></textarea>
                </div>
                <div class=""col"">
                    <span class=""rounded-circle"">If you didn't find what you needed, please tell us what info you are seeking?</span>
                    <textarea name=""formGreivance"" class=""form-control"" maxlength=""200"" spellcheck=""true""></textarea>
                </div>
            </div>
            <div class=""row"">
                <div class=""col"">
                    <label class=""form-label"">How easy is it to get the information from the website?</label>
                    <div class=""form-check"">
                      ");
            WriteLiteral(@"  <input type=""radio"" name=""formContentFindStatus"" title=""Very Easy"" value=""VeryEasy"" class=""form-check-input"" id=""formVeryEasy"" />
                        <label for=""formVeryEasy"" class=""form-check-label"">Very Easy</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentFindStatus"" title=""Easy"" value=""Easy"" class=""form-check-input"" id=""formEasy"" />
                        <label for=""formEasy"" class=""form-check-label"">Easy</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentFindStatus"" title=""Average"" value=""Average"" class=""form-check-input"" id=""formAverage"" />
                        <label for=""formAverage"" class=""form-check-label"">Average</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentFindStatus"" title=""Dificult"" value=""Dificult""");
            WriteLiteral(@" class=""form-check-input"" id=""formDificult"" />
                        <label for=""formDificult"" class=""form-check-label"">Dificult</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentFindStatus"" title=""Very Dificult"" value=""VeryDificult"" class=""form-check-input"" id=""formVeryDificult"" />
                        <label for=""formVeryDificult"" class=""form-check-label"">Very Dificult</label>
                    </div>
                </div>
                <div class=""col"">
                    <label class=""form-label"">What is the likelihood to return to the website?</label>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentQuality"" title=""Extremely"" value=""Extremely"" class=""form-check-input"" id=""formExtreme"" />
                        <label for=""formExtreme"" class=""form-check-label"">Extremely Likely</label>
                    </div>
                    <di");
            WriteLiteral(@"v class=""form-check"">
                        <input type=""radio"" name=""formContentQuality"" title=""Very"" value=""Very"" class=""form-check-input"" id=""formVery"" />
                        <label for=""formVery"" class=""form-check-label"">Very Likely</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentQuality"" title=""Moderate"" value=""Moderate"" class=""form-check-input"" id=""formModerate"" />
                        <label for=""formModerate"" class=""form-check-label"">Moderate Likely</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formContentQuality"" title=""Slight"" value=""Slight"" class=""form-check-input"" id=""formSlight"" />
                        <label for=""formSlight"" class=""form-check-label"">Slight Likely</label>
                    </div>
                    <div class=""form-check"">
                        <input type=""radio"" name=""formCo");
            WriteLiteral(@"ntentQuality"" title=""Unlikely"" value=""Unlikely"" class=""form-check-input"" id=""formUnlikely"" />
                        <label for=""formUnlikely"" class=""form-check-label"">Unlikely to return</label>
                    </div>
                </div>
            </div>
            <div class=""row"">
");
            WriteLiteral(@"                <div class=""col"">
                    <span class=""rounded-circle"">Please provide any additional comments or suggestions.</span>
                    <textarea name=""formSuggestions"" class=""form-control"" maxlength=""200"" spellcheck=""true""></textarea>
                </div>

            </div>

            <div class=""row"">
                <div class=""col-12"">
                    <input id=""formSubmit"" type=""submit"" title=""Submit"" class=""btn btn-primary"" />
                </div>
            </div>
        </div>
");
#nullable restore
#line 128 "C:\Users\rajes\source\repos\NewCoreApplication\rajeshpattanaik\DemoCoreApplication\NewCoreApplication\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\carna\Desktop\UTM\AWOS\PROYECTO\ferroapp-master\FerroApp.GUI\Pages\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6497e7bcc2ee81a8234e3bb6a85feb67702c4fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FerroApp.GUI.Pages.Pages_Login), @"mvc.1.0.razor-page", @"/Pages/Login.cshtml")]
namespace FerroApp.GUI.Pages
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
#line 1 "C:\Users\carna\Desktop\UTM\AWOS\PROYECTO\ferroapp-master\FerroApp.GUI\Pages\_ViewImports.cshtml"
using FerroApp.GUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6497e7bcc2ee81a8234e3bb6a85feb67702c4fc", @"/Pages/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"865e65055927b4f8b1094ecd6111fbe074587b62", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Login : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Multi.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\carna\Desktop\UTM\AWOS\PROYECTO\ferroapp-master\FerroApp.GUI\Pages\Login.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6497e7bcc2ee81a8234e3bb6a85feb67702c4fc4090", async() => {
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
            WriteLiteral(@"
<link href='https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/css/bootstrap.min.css'>
<div class=""container-fluid mt-5"">
    <div class=""row no-gutter"">
        <div class=""col-md-6 d-none d-md-flex bg-image""></div>
        <div class=""col-md-6 bg-light"">
            <div class=""login d-flex align-items-center py-5"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-lg-7 col-xl-6 mx-auto"">
                            <h3 class=""display-4"">LOGIN!!</h3> <br>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6497e7bcc2ee81a8234e3bb6a85feb67702c4fc5775", async() => {
                WriteLiteral("\n                                <div class=\"form-group mb-3\"> <input id=\"inputEmail\" type=\"email\" placeholder=\"Email address\"");
                BeginWriteAttribute("required", " required=\"", 864, "\"", 875, 0);
                EndWriteAttribute();
                BeginWriteAttribute("autofocus", " autofocus=\"", 876, "\"", 888, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control rounded-pill border-0 shadow-sm px-4\"> </div>\n                                <div class=\"form-group mb-3\"> <input id=\"inputPassword\" type=\"password\" placeholder=\"Password\"");
                BeginWriteAttribute("required", " required=\"", 1082, "\"", 1093, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""form-control rounded-pill border-0 shadow-sm px-4 text-danger""><br> </div>
                                <div class=""custom-control custom-checkbox mb-3""> <input id=""customCheck1"" type=""checkbox"" checked class=""custom-control-input""> <label for=""customCheck1"" class=""custom-control-label"">Remember password</label> </div> <button type=""submit"" class=""btn btn-danger btn-block text-uppercase mb-2 rounded-pill shadow-sm"">Sign in</button>
                                <div class=""text-center d-flex justify-content-between mt-4"">
                                    <p> OR &nbsp<a href="" "" class=""font-italic text-muted""> <u>Create Account</u></a></p>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n");
            WriteLiteral(@"<script src='https://maxcdn.bootstrapcdn.com/bootstrap/4.1.1/js/bootstrap.min.js'></script>
<script src='https://cdnjs.cloudflare.com/ajax/libs/jquery/3.2.1/jquery.min.js'></script>

<!--<!doctype html>
<!--[if lt IE 7]>      <html class=""no-js lt-ie9 lt-ie8 lt-ie7"" lang=""""> <![endif]-->
<!--[if IE 7]>         <html class=""no-js lt-ie9 lt-ie8"" lang=""""> <![endif]-->
<!--[if IE 8]>         <html class=""no-js lt-ie9"" lang=""""> <![endif]-->
<!--[if gt IE 8]><!-->
<!--<html class=""no-js"" lang=""en"">-->
<!--<![endif]-->
<!--<head>
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <title>Login</title>
    <meta name=""description"" content=""Sufee Admin - HTML5 Admin Template"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">

    <link rel=""apple-touch-icon"" href=""apple-icon.png"">
    <link rel=""shortcut icon"" href=""favicon.ico"">
    <script src=""~/Vendor/assets/js/main.js""></script>

    <link href=""~/Vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet""");
            WriteLiteral(@" />
    <link href=""~/Vendor/font-awesome/css/font-awesome.min.css"" rel=""stylesheet"" />
    <link href=""~/Vendor/themify-icons/css/themify-icons.css"" rel=""stylesheet"" />
    <link href=""~/Vendor/flag-icon-css/css/flag-icon.min.css"" rel=""stylesheet"" />
    <link href=""~/Vendor/selectFX/css/cs-skin-elastic.css"" rel=""stylesheet"" />
    <link href=""~/Vendor/assets/css/style.css"" rel=""stylesheet"" />

    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400,600,700,800' rel='stylesheet' type='text/css'>



</head>

<body class=""bg-white"">

    <div class=""sufee-login d-flex align-content-center flex-wrap"">
        <div class=""container"">
            <div class=""login-content"">-->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FerroApp.GUI.Pages.LoginModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FerroApp.GUI.Pages.LoginModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FerroApp.GUI.Pages.LoginModel>)PageContext?.ViewData;
        public FerroApp.GUI.Pages.LoginModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

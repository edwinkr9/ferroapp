#pragma checksum "C:\Users\edwin\Desktop\Proyecto_FerroApp\FerroApp\FerroApp.GUI\Pages\AdminPages\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee9fc3a830b4fb31d7a7c7589faea2569b5da9da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(FerroApp.GUI.Pages.AdminPages.Pages_AdminPages_Admin), @"mvc.1.0.razor-page", @"/Pages/AdminPages/Admin.cshtml")]
namespace FerroApp.GUI.Pages.AdminPages
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
#line 1 "C:\Users\edwin\Desktop\Proyecto_FerroApp\FerroApp\FerroApp.GUI\Pages\_ViewImports.cshtml"
using FerroApp.GUI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee9fc3a830b4fb31d7a7c7589faea2569b5da9da", @"/Pages/AdminPages/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12d73addc0bfb2807068591311da99f7059fc1b0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AdminPages_Admin : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("au-form-icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\edwin\Desktop\Proyecto_FerroApp\FerroApp\FerroApp.GUI\Pages\AdminPages\Admin.cshtml"
  
    Layout = "~/Pages/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- MAIN CONTENT-->\r\n<div class=\"main-content\">\r\n    <div class=\"section__content section__content--p30\">\r\n        <div class=\"container-fluid\">\r\n");
            WriteLiteral(@"            <div class=""row"">
                <div class=""col-6"">
                    <button class=""au-btn au-btn--block au-btn--green m-b-20"" type=""submit"">Agregar Producto</button>
                </div>
                <div class=""col-6"">
                    <button class=""au-btn au-btn--block au-btn--green m-b-20"" type=""submit"">Agregar Gerente</button>
                </div>
                
            </div>
            <div class=""row"">
                <div class=""col-lg-9"">
                    <h2 class=""title-1 m-b-25"">Lista de Productos</h2>
                    <div class=""table-responsive table--no-card m-b-40"">
                        <table class=""table table-borderless table-striped table-earning"">
                            <thead>
                                <tr>
                                    <th>Fecha</th>
                                    <th>ID</th>
                                    <th>Nombre</th>
                                    <th class=""text-right""");
            WriteLiteral(@">Modelo</th>
                                    <th class=""text-right"">Precio</th>
                                    <th class=""text-right"">Piezas</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>2018-09-29 05:57</td>
                                    <td>100398</td>
                                    <td>Martillo KD</td>
                                    <td class=""text-right"">KD-99UH</td>
                                    <td class=""text-right"">$99.00</td>
                                    <td class=""text-right"">92</td>
                                </tr>
                                <tr>
                                    <td>2018-09-28 01:22</td>
                                    <td>100397</td>
                                    <td>Pala T10</td>
                                    <td class=""text-right"">T10K</td>
         ");
            WriteLiteral(@"                           <td class=""text-right"">$500</td>
                                    <td class=""text-right"">8</td>
                                </tr>
                                <tr>
                                    <td>2018-09-27 02:12</td>
                                    <td>100396</td>
                                    <td>Pintura Blanca 10L</td>
                                    <td class=""text-right"">Pint115</td>
                                    <td class=""text-right"">$380</td>
                                    <td class=""text-right"">25</td>
                                </tr>
                                <tr>
                                    <td>2018-09-26 23:06</td>
                                    <td>100395</td>
                                    <td>Kit Desarmadores</td>
                                    <td class=""text-right"">KFG9</td>
                                    <td class=""text-right"">$800</td>
                               ");
            WriteLiteral(@"     <td class=""text-right"">14</td>
                                </tr>
                                <tr>
                                    <td>2018-09-25 19:03</td>
                                    <td>100393</td>
                                    <td>Caja de Herramientas</td>
                                    <td class=""text-right"">10MM</td>
                                    <td class=""text-right"">$180</td>
                                    <td class=""text-right"">90</td>
                                </tr>
                                <tr>
                                    <td>2018-09-29 05:57</td>
                                    <td>100392</td>
                                    <td>Cinta Negra Rollo 10M</td>
                                    <td class=""text-right"">CNR10</td>
                                    <td class=""text-right"">$80</td>
                                    <td class=""text-right"">70</td>
                                </tr>
           ");
            WriteLiteral(@"                     <tr>
                                    <td>2018-09-24 19:10</td>
                                    <td>100391</td>
                                    <td>Resistol Blanco</td>
                                    <td class=""text-right"">C430W</td>
                                    <td class=""text-right"">$95</td>
                                    <td class=""text-right"">65</td>
                                </tr>
                                <tr>
                                    <td>2018-09-22 00:43</td>
                                    <td>100393</td>
                                    <td>Tornillos para concreto 1Kg</td>
                                    <td class=""text-right"">TC1K</td>
                                    <td class=""text-right"">$45</td>
                                    <td class=""text-right"">60</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>");
            WriteLiteral(@"
                </div>
                <div class=""col-lg-3"">
                    <h2 class=""title-1 m-b-25"">Gerentes</h2>
                    <div class=""au-card au-card--bg-blue au-card-top-countries m-b-40"">
                        <div class=""au-card-inner"">
                            <div class=""table-responsive"">
                                <table class=""table table-top-countries"">
                                    <tbody>
                                        <tr>
                                            <td>Carlos Be</td>
");
            WriteLiteral("                                        </tr>\r\n                                        <tr>\r\n                                            <td>Edwin Koh</td>\r\n");
            WriteLiteral(@"                                        </tr>
                                        <tr>
                                            <td>Mariana Gonzales</td>
                                        </tr>
                                        <tr>
                                            <td>Andrea Servilleta</td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-lg-6"">
                    <div class=""au-card au-card--no-shadow au-card--no-pad m-b-40"">
                        <div class=""au-card-title"" style=""background-image:url('images/bg-title-01.jpg');"">
                            <div class=""bg-overlay bg-overlay--blue""></div>
                            <h3>
                                <i class=""zm");
            WriteLiteral(@"di zmdi-account-calendar""></i>26 April, 2018
                            </h3>
                            <button class=""au-btn-plus"">
                                <i class=""zmdi zmdi-plus""></i>
                            </button>
                        </div>
                        <div class=""au-task js-list-load"">
                            <div class=""au-task__title"">
                                <p>Tasks for John Doe</p>
                            </div>
                            <div class=""au-task-list js-scrollbar3"">
                                <div class=""au-task__item au-task__item--danger"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Meeting about plan for Admin Template 2018</a>
                                        </h5>
                                        <span class=""time"">10:00 AM</span>
                           ");
            WriteLiteral(@"         </div>
                                </div>
                                <div class=""au-task__item au-task__item--warning"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">11:00 AM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--primary"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Meeting about plan for Admin Template 2018</a>
                                        </h5>
                                        <span class=""time"">02:00 PM</span>
              ");
            WriteLiteral(@"                      </div>
                                </div>
                                <div class=""au-task__item au-task__item--success"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">03:30 PM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--danger js-load-item"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Meeting about plan for Admin Template 2018</a>
                                        </h5>
                                        <span class=""time"">10:00 ");
            WriteLiteral(@"AM</span>
                                    </div>
                                </div>
                                <div class=""au-task__item au-task__item--warning js-load-item"">
                                    <div class=""au-task__item-inner"">
                                        <h5 class=""task"">
                                            <a href=""#"">Create new task for Dashboard</a>
                                        </h5>
                                        <span class=""time"">11:00 AM</span>
                                    </div>
                                </div>
                            </div>
                            <div class=""au-task__footer"">
                                <button class=""au-btn au-btn-load js-load-btn"">load more</button>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""au-card au-card--n");
            WriteLiteral(@"o-shadow au-card--no-pad m-b-40"">
                        <div class=""au-card-title"" style=""background-image:url('images/bg-title-02.jpg');"">
                            <div class=""bg-overlay bg-overlay--blue""></div>
                            <h3>
                                <i class=""zmdi zmdi-comment-text""></i>New Messages
                            </h3>
                            <button class=""au-btn-plus"">
                                <i class=""zmdi zmdi-plus""></i>
                            </button>
                        </div>
                        <div class=""au-inbox-wrap js-inbox-wrap"">
                            <div class=""au-message js-list-load"">
                                <div class=""au-message__noti"">
                                    <p>
                                        You Have
                                        <span>2</span>

                                        new messages
                                    </p>
              ");
            WriteLiteral(@"                  </div>
                                <div class=""au-message-list"">
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">John Smith</h5>
                                                    <p>Have sent a photo</p>
                                                </div>
                                    ");
            WriteLiteral(@"        </div>
                                            <div class=""au-message__item-time"">
                                                <span>12 Min ago</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item unread"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-03.jpg"" alt=""Nicholas Martinez"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                 ");
            WriteLiteral(@"                                   <h5 class=""name"">Nicholas Martinez</h5>
                                                    <p>You are now connected on message</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>11:00 PM</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""im");
            WriteLiteral(@"ages/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum dolor sit amet</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message");
            WriteLiteral(@"__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Sunday</span>
                                            </div>
                                        </div>
                                ");
            WriteLiteral(@"    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap online"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-04.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Michelle Sims</h5>
                                                    <p>Lorem ipsum dolor sit amet</p>
                                                </div>
                                            </div>
                                 ");
            WriteLiteral(@"           <div class=""au-message__item-time"">
                                                <span>Yesterday</span>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""au-message__item js-load-item"">
                                        <div class=""au-message__item-inner"">
                                            <div class=""au-message__item-text"">
                                                <div class=""avatar-wrap"">
                                                    <div class=""avatar"">
                                                        <img src=""images/icon/avatar-05.jpg"" alt=""Michelle Sims"">
                                                    </div>
                                                </div>
                                                <div class=""text"">
                                                    <h5 class=""name"">Mic");
            WriteLiteral(@"helle Sims</h5>
                                                    <p>Purus feugiat finibus</p>
                                                </div>
                                            </div>
                                            <div class=""au-message__item-time"">
                                                <span>Sunday</span>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div class=""au-message__footer"">
                                    <button class=""au-btn au-btn-load js-load-btn"">load more</button>
                                </div>
                            </div>
                            <div class=""au-chat"">
                                <div class=""au-chat__title"">
                                    <div class=""au-chat-info"">
                                        <div class=""avatar-wr");
            WriteLiteral(@"ap online"">
                                            <div class=""avatar avatar--small"">
                                                <img src=""images/icon/avatar-02.jpg"" alt=""John Smith"">
                                            </div>
                                        </div>
                                        <span class=""nick"">
                                            <a href=""#"">John Smith</a>
                                        </span>
                                    </div>
                                </div>
                                <div class=""au-chat__content"">
                                    <div class=""recei-mess-wrap"">
                                        <span class=""mess-time"">12 Min ago</span>
                                        <div class=""recei-mess__inner"">
                                            <div class=""avatar avatar--tiny"">
                                                <img src=""images/icon/avatar-02.jpg"" alt=""John ");
            WriteLiteral(@"Smith"">
                                            </div>
                                            <div class=""recei-mess-list"">
                                                <div class=""recei-mess"">Lorem ipsum dolor sit amet, consectetur adipiscing elit non iaculis</div>
                                                <div class=""recei-mess"">Donec tempor, sapien ac viverra</div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class=""send-mess-wrap"">
                                        <span class=""mess-time"">30 Sec ago</span>
                                        <div class=""send-mess__inner"">
                                            <div class=""send-mess-list"">
                                                <div class=""send-mess"">Lorem ipsum dolor sit amet, consectetur adipiscing elit non iaculis</div>
                                            <");
            WriteLiteral("/div>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                                <div class=\"au-chat-textfield\">\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee9fc3a830b4fb31d7a7c7589faea2569b5da9da27467", async() => {
                WriteLiteral(@"
                                        <input class=""au-input au-input--full au-input--h65"" type=""text"" placeholder=""Type a message"">
                                        <button class=""au-input-icon"">
                                            <i class=""zmdi zmdi-camera""></i>
                                        </button>
                                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-12"">
                    <div class=""copyright"">
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- END MAIN CONTENT-->
<!-- END PAGE CONTAINER-->
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FerroApp.GUI.Pages.AdminPages.AdminModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FerroApp.GUI.Pages.AdminPages.AdminModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<FerroApp.GUI.Pages.AdminPages.AdminModel>)PageContext?.ViewData;
        public FerroApp.GUI.Pages.AdminPages.AdminModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591

#pragma checksum "/Users/tunc/Documents/C#/Edura/Edura.WebUI/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42c5090adb9a04e7420c7df61b2985f78f63ae65"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
#line 1 "/Users/tunc/Documents/C#/Edura/Edura.WebUI/Views/_ViewImports.cshtml"
using Edura.WebUI.Entity;

#line default
#line hidden
#line 2 "/Users/tunc/Documents/C#/Edura/Edura.WebUI/Views/_ViewImports.cshtml"
using Edura.WebUI.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42c5090adb9a04e7420c7df61b2985f78f63ae65", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8afddfe3ccab2dfef36319758d8facf6dda694", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 188, true);
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"en\">\n\n<!-- Mirrored from demos.codeniner.com/edura/shop-catalog-sidebar-left.html by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 13 Jul 2017 15:11:18 GMT -->\n");
            EndContext();
            BeginContext(188, 1121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c5090adb9a04e7420c7df61b2985f78f63ae654372", async() => {
                BeginContext(194, 891, true);
                WriteLiteral(@"
    <!-- METAS -->
    <meta charset=""utf-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta name=""description"" content="""">
    <meta name=""author"" content="""">

    <!-- TITLE -->
    <title>Edura - Multipurpose Website Template</title>

    <!-- FAVICON -->
    <link rel=""shortcut icon"" href=""/modules/edura/images/favicon.png""/>

    <!-- LOAD MAIN CSS -->
    <link href=""/modules/edura/style.css"" rel=""stylesheet"" type=""text/css"">

    <!-- LOAD COLOR STYLE (OPTONAL) CSS -->
    <link href=""/modules/edura/styles/lunar.css"" rel=""stylesheet"" type=""text/css"" id=""colorstyle"">

    <!-- LOAD CUSTOM CSS -->
    <link href=""/modules/edura/custom.css"" rel=""stylesheet"" type=""text/css"">

    <!-- LOAD DEMO CSS -->
    <link href=""/modules/edura/demo/demo.css"" rel=""stylesheet"" type=""text/css"">

");
                EndContext();
                BeginContext(1301, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1309, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(1311, 14703, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c5090adb9a04e7420c7df61b2985f78f63ae656586", async() => {
                BeginContext(1317, 7877, true);
                WriteLiteral(@"

    <!-- WRAPPER START -->
    <div id=""wrapper"">
        <!-- HEADER START -->
        <section id=""header"">
            <!-- Fixed navbar -->
            <nav class=""navbar navbar-default navbar-fixed-top"">
            <div class=""container"">
                <div class=""navbar-header"">
                    <button type=""button"" class=""navbar-toggle collapsed"" data-toggle=""collapse"" data-target=""#navbar"" aria-expanded=""false"" aria-controls=""navbar"">
                        <span class=""sr-only"">Toggle navigation</span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                        <span class=""icon-bar""></span>
                    </button>
                    <a class=""navbar-brand"" href=""#"">
                        <img src=""/modules/images/edura-logo.png"" alt=""Edura - Multipurpose Website Template"">
                    </a>
                </div>
                <div id=""navbar"" class=""navbar-collapse collapse"">
                    <u");
                WriteLiteral(@"l class=""nav navbar-nav"">
                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Home</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""index-2.html"">Homepage 1</a></li>
                                <li><a href=""index-3.html"">Homepage 2</a></li>
                                <li><a href=""index-4.html"">Homepage 3</a></li>
                                <li><a href=""index-5.html"">Homepage 4</a></li>
                                <li><a href=""index-6.html"">Home 5 (Full Carousel)</a></li>
                            </ul>
                        </li>

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Pages</a>
                            ");
                WriteLiteral(@"<ul class=""dropdown-menu"">
                                <li><a href=""about-us.html"">About Us</a></li>
                                <li><a href=""pricing.html"">Pricing</a></li>
                                <li><a href=""services.html"">Services</a></li>
                                <li><a href=""faq.html"">FAQ</a></li>
                                <li><a href=""404.html"">404 Error</a></li>
                            </ul>
                        </li>

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Features</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""typography.html"">Typography</a></li>
                                <li><a href=""grid-system.html"">Grid System</a></li>
                                <li><a href=""elements.html"">Elements</a></li>
                                <l");
                WriteLiteral(@"i role=""separator"" class=""divider""></li>
                                <li class=""dropdown-header"">Menu Title</li>
                                <li class=""dropdown-submenu"">
                                  <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">More..</a>
                                  <ul class=""dropdown-menu"">
                                      <li><a href=""#"">3rd level</a></li>
                                      <li><a href=""#"">3rd level</a></li>
                                  </ul>
                                </li>

                            </ul>
                        </li>

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Portfolio</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""portfolio-single.html"">Single Project</a></li>
                 ");
                WriteLiteral(@"               <li><a href=""portfolio-2cl.html"">2 Columns Portfolio</a></li>
                                <li><a href=""portfolio-3cl.html"">3 Columns Portfolio</a></li>
                                <li><a href=""portfolio-4cl.html"">4 Columns Portfolio</a></li>
                            </ul>
                        </li>

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Blog</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""blog-single.html"">Single Article</a></li>
                                <li><a href=""blog-grid-2cl.html"">Blog Grid 2 Columns</a></li>
                                <li><a href=""blog-grid-3cl.html"">Blog Grid 3 Columns</a></li>
                                <li><a href=""blog-list.html"">Blog List</a></li>
                            </ul>
                        </li>");
                WriteLiteral(@"

                        <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Shop</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""shop-product.html"">Product</a></li>
                                <li><a href=""shop-product-sidebar-left.html"">Product Sidebar Left</a></li>
                                <li><a href=""shop-product-sidebar-right.html"">Product Sidebar Right</a></li>
                                <li><a href=""shop-catalog.html"">Catalog</a></li>
                                <li><a href=""shop-catalog-sidebar-left.html"">Catalog Sidebar Left</a></li>
                                <li><a href=""shop-catalog-sidebar-right.html"">Catalog Sidebar Right</a></li>
                                <li><a href=""shop-cart.html"">Shopping Cart</a></li>
                            </ul>
                        </li>

   ");
                WriteLiteral(@"                     <li class=""dropdown"">
                            <a href=""#"" class=""dropdown-toggle"" data-toggle=""dropdown"" data-hover=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""false"">Contact Us</a>
                            <ul class=""dropdown-menu"">
                                <li><a href=""contactus-1.html"">Contact Us 1</a></li>
                                <li><a href=""contactus-2.html"">Contact Us 2</a></li>
                                <li><a href=""contactus-3.html"">Contact Us 3</a></li>
                                <li><a href=""contactus-4.html"">Contact Us 4</a></li>
                            </ul>
                        </li>

                        <li><a href=""shop-cart.html""><i class=""fa fa-shopping-cart fa-fw""></i> Cart (2)</a></li>


                    </ul>



                </div><!--/.nav-collapse -->
            </div>
            </nav>
        </section>
        <!-- HEADER END -->


        <!-- PAGE TITLE START -->
        <section id=""title"" cl");
                WriteLiteral(@"ass=""container-fluid wow fadeInDown"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-xs-6"">
                        <h1>Shop <small>Catalog</small></h1>
                    </div>
                    <div class=""col-xs-6 text-right breadcrumbs"">
                        <ul class=""list-inline list-unstyled"">
                            <li><a href=""index-2.html"">Home</a></li>
                            <li>/</li>
                            <li>Shop</li>
                        </ul>
                    </div>
                </div>
            </div>
        </section>
        <!-- PAGE TITLE END -->


        <!-- CONTENT START -->
        ");
                EndContext();
                BeginContext(9195, 12, false);
#line 178 "/Users/tunc/Documents/C#/Edura/Edura.WebUI/Views/Shared/_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(9207, 2934, true);
                WriteLiteral(@"
        <!-- CONTENT END -->

        <!-- FOOTER START -->
        <section id=""footer"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-3"">
                        <img src=""/modules/images/edura-logo.png"" alt=""Edura - Multipurpose Website Template"">
                        <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer nec odio. Praesent libero. Sed cursus ante dapibus diam. Sed nisi. Nulla quis sem at nibh elementum imperdiet. Duis sagittis ipsum. Praesent mauris. <b>Lorem ipsum dolor sit amet, consectetur adipiscing</b>.</p>
                        <br>
                        <ul class=""list-unstyled list-inline social-icons"">
                            <li><a href=""#"" class=""facebook""><i class=""fa fa-facebook facebook""></i></a></li>
                            <li><a href=""#"" class=""twitter""><i class=""fa fa-twitter twitter""></i></a></li>
                            <li><a href=""#"" class=""googleplus""><i class=""fa fa-goog");
                WriteLiteral(@"le-plus googleplus""></i></a></li>
                            <li><a href=""#"" class=""youtube""><i class=""fa fa-youtube youtube""></i></a></li>
                            <li><a href=""#"" class=""linkedin""><i class=""fa fa-linkedin linkedin""></i></a></li>
                        </ul>
                    </div>
                    <div class=""col-md-3"">
                        <h4>PAGES</h4>
                        <ul class=""list-unstyled"">
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">HOME</a></li>
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">ABOUT US</a></li>
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">SERVICES</a></li>
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">BLOG</a></li>
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">STOR");
                WriteLiteral(@"E</a></li>
                            <li><i class=""fa fa-caret-right fa-fw"" aria-hidden=""true""></i> <a href=""#"">PRIVACY POLICY</a></li>
                        </ul>
                    </div>

                    <div class=""col-md-3"">
                        <h4>CONTACT US</h4>
                        <p><i class=""fa fa-map-pin fa-fw""></i> 379 5th Ave, New York, 10001, USA</p>
                        <p><i class=""fa fa-phone fa-fw""></i> +(112) 345 6879</p>
                        <p><i class=""fa fa-phone fa-fw""></i> +(112) 345 6879</p>
                        <p><i class=""fa fa-envelope fa-fw""></i> hello@example.com</p>
                    </div>

                    <div class=""col-md-3"">
                        <h4>NEWSLETTER</h4>
                        <p>Subscribe to our monthly newsletter and stay updated with the latest news and info.</p>
                        ");
                EndContext();
                BeginContext(12141, 681, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42c5090adb9a04e7420c7df61b2985f78f63ae6518787", async() => {
                    BeginContext(12172, 643, true);
                    WriteLiteral(@"
                            <div class=""form-group"">
                                <div class=""input-group"">
                                    <div class=""input-group-addon""><i class=""fa fa-envelope-o""></i></div>
                                    <input type=""email"" class=""form-control"" id=""email"" placeholder=""Your Email Address"" required>
                                </div>
                            </div>
                            <div class=""form-group pull-right"">
                                <button type=""submit"" class=""btn btn-primary"">Subscribe</button>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(12822, 3185, true);
                WriteLiteral(@"
                    </div>
                </div>

                <div class=""row"">
                    <hr>
                    <div class=""col-md-12 text-center bottom"">
                        <p>Copyright &copy; 2016 Codeniner. All rights reserved.</p>
                    </div>
                </div>
            </div>
        </section>
        <!-- FOOTER END -->


    </div>
    <!-- WRAPPER END -->

    <!-- back to top button -->
    <a id=""back-to-top"" href=""#"" class=""btn btn-primary btn-lg back-to-top"" role=""button"" title=""Click to return on the top page"" data-toggle=""tooltip"" data-placement=""left""><span class=""glyphicon glyphicon-chevron-up""></span></a>



    <!-- MAIN JS FILES REQUIRED ON ALL PAGES -->
    <script src=""/modules/edura/vendor/jquery/jquery.min.js""></script>

    <script src=""/modules/edura/vendor/bootstrap/js/bootstrap.min.js""></script>
    <script src=""/modules/edura/vendor/bootstrap-hover-dropdown/bootstrap-hover-dropdown.js""></script>
    <script src=""/modules/edura/vendor/w");
                WriteLiteral(@"ow/wow.min.js""></script>
    <script src=""/modules/edura/vendor/imagesloaded/imagesloaded.pkgd.min.js""></script>
    <script src=""/modules/edura/vendor/SmoothScroll/SmoothScroll.min.js""></script>

    <script src=""/modules/edura/vendor/waypoints/waypoints.min.js""></script>
    <script src=""/modules/edura/vendor/counterup/jquery.counterup.min.js""></script>


    <!-- HERO SLIDER-->
    <script src=""/modules/edura/vendor/hero-slider/js/modernizr.js""></script>
    <script src=""/modules/edura/vendor/hero-slider/js/main.js""></script>

    <!-- OWL CAROUSEL -->
    <script src=""/modules/edura/vendor/owl-carousel/owl.carousel.js""></script>

    <!-- FILTERIZR -->
    <script src=""/modules/edura/vendor/jquery/jquery.filterizr.js""></script>

    <!-- EDURA JS REQUIRED ON ALL PAGES-->
    <script src=""/modules/edura/edura.js""></script>

    <script>
      (function(i,s,o,g,r,a,m){i['GoogleAnalyticsObject']=r;i[r]=i[r]||function(){
      (i[r].q=i[r].q||[]).push(arguments)},i[r].l=1*new Date();a=s.createElement(o),
    ");
                WriteLiteral(@"  m=s.getElementsByTagName(o)[0];a.async=1;a.src=g;m.parentNode.insertBefore(a,m)
      })(window,document,'script','../../www.google-analytics.com/analytics.js','ga');

      ga('create', 'UA-81122143-3', 'auto');
      ga('send', 'pageview');

    </script>

    <!-- STYLE SWITCHER -->
    <script src=""demo/demo.js""></script>
    <div id=""styleswitcher"">
        <input id=""settings-btn"" class=""settings-btn"" type=""checkbox"">
        <label for=""settings-btn"" class=""settings-box-element""><i class=""fa fa-2x fa-gear""></i></label>
        <div class=""buttons-wrapper settings-box-element"">
            <h4 class=""text-uppercase"">Change Color Style</h4>
            <p><button id=""demo-lunar"" class=""btn demo-btn demo-lunar"">Lunar (Default)</button></p>
            <p><button id=""demo-blue"" class=""btn demo-btn demo-blue"">Blue</button></p>
            <p><button id=""demo-green"" class=""btn demo-btn demo-green"">Green</button></p>
            <p><button id=""demo-red"" class=""btn demo-btn demo-red"">Red</button></p>
       ");
                WriteLiteral("     <p><button id=\"demo-orange\" class=\"btn demo-btn demo-orange\">Orange</button></p>\n        </div>\n    </div>\n\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(16014, 164, true);
            WriteLiteral("\n\n<!-- Mirrored from demos.codeniner.com/edura/shop-catalog-sidebar-left.html by HTTrack Website Copier/3.x [XR&CO\'2014], Thu, 13 Jul 2017 15:11:18 GMT -->\n</html>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591

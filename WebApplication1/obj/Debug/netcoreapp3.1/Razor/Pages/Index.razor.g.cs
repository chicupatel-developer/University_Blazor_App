#pragma checksum "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1524b653e18f7b4af0ee13d0af52880e317226d4"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorServerApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using BlazorServerApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using BlazorServerApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\BlazorApps\BlazorServerApp\WebApplication1\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>University of Winnipeg [GL_ACCT App]</h3>\r\n<p></p>\r\n");
            __builder.OpenComponent<MudBlazor.MudCard>(1);
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardContent>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(7);
                    __builder3.AddAttribute(8, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 7 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(10, "Group by [GL ACCT NO]");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(11, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(12);
                    __builder3.AddAttribute(13, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 8 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                                 DividerType.Middle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(14, "Class", "my-6");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(15, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(16);
                    __builder3.AddAttribute(17, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 9 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(19, "Sum(Debit) Sum(Credit)");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(21);
                    __builder3.AddAttribute(22, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 10 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                                 DividerType.Middle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(23, "Class", "my-6");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudText>(25);
                    __builder3.AddAttribute(26, "Typo", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Typo>(
#nullable restore
#line 11 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                       Typo.h5

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(28, "X-Fer To Xcel File");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(29, "\r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudDivider>(30);
                    __builder3.AddAttribute(31, "DividerType", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.DividerType>(
#nullable restore
#line 12 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Index.razor"
                                 DividerType.Middle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(32, "Class", "my-6");
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(33, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCardActions>(35);
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(37, "        \r\n        ");
                    __builder3.OpenComponent<MudBlazor.MudElement>(38);
                    __builder3.AddAttribute(39, "HtmlTag", "a");
                    __builder3.AddAttribute(40, "Class", "ma-0");
                    __builder3.AddAttribute(41, "Style", "color:red;font-weight:bold;");
                    __builder3.AddAttribute(42, "href", "https://github.com/Ankithorizon/University-Admin");
                    __builder3.AddAttribute(43, "target", "blank");
                    __builder3.AddAttribute(44, "rel", "noopener noreferrer");
                    __builder3.AddAttribute(45, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(46, "\r\n            Source-Code\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(47, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(48, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591

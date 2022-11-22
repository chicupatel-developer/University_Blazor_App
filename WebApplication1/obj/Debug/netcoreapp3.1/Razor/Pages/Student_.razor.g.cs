#pragma checksum "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "274fa2dbf68f02bd81ff734ae5d6a005a1e7b2fc"
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
#nullable restore
#line 7 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
using DataAccess.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
using DataAccess.DTO;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Student_ : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>University-Students</h3>\r\n\r\n\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudPaper>(1);
            __builder.AddAttribute(2, "Square", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 12 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                  true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Class", "d-flex justify-space-around");
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    \r\n    ");
                __Blazor.BlazorServerApp.Pages.Student_.TypeInference.CreateMudTable_0(__builder2, 6, 7, 
#nullable restore
#line 14 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                      GetStudents()

#line default
#line hidden
#nullable disable
                , 8, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                           (x) => ClickEvent(selectedStudents.LastOrDefault())

#line default
#line hidden
#nullable disable
                ), 9, "350px", 10, 
#nullable restore
#line 17 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                          Breakpoint.Sm

#line default
#line hidden
#nullable disable
                , 11, 
#nullable restore
#line 18 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                              true

#line default
#line hidden
#nullable disable
                , 12, 
#nullable restore
#line 20 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                      hover

#line default
#line hidden
#nullable disable
                , 13, 
#nullable restore
#line 19 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                   selectedStudents

#line default
#line hidden
#nullable disable
                , 14, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectedStudents = __value, selectedStudents)), 15, (__builder3) => {
                    __builder3.AddMarkupContent(16, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(17);
                    __builder3.AddAttribute(18, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(19, "#");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(20, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(21);
                    __builder3.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(23, "First Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(24, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(25);
                    __builder3.AddAttribute(26, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(27, "Last Name");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(28, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(29);
                    __builder3.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(31, "Phone");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(32, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTh>(33);
                    __builder3.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(35, "Email");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(36, "\r\n        ");
                }
                , 37, (context) => (__builder3) => {
                    __builder3.AddMarkupContent(38, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(39);
                    __builder3.AddAttribute(40, "DataLabel", "StudentId");
                    __builder3.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(42, 
#nullable restore
#line 29 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                          context.StudentId

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(43, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(44);
                    __builder3.AddAttribute(45, "DataLabel", "FirstName");
                    __builder3.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(47, 
#nullable restore
#line 30 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                          context.FirstName

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(48, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(49);
                    __builder3.AddAttribute(50, "DataLabel", "LastName");
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(52, 
#nullable restore
#line 31 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                         context.LastName

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(53, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(54);
                    __builder3.AddAttribute(55, "DataLabel", "PhoneNumber");
                    __builder3.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(57, 
#nullable restore
#line 32 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                            context.PhoneNumber

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(58, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTd>(59);
                    __builder3.AddAttribute(60, "DataLabel", "Email");
                    __builder3.AddAttribute(61, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(62, 
#nullable restore
#line 33 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                      context.Email

#line default
#line hidden
#nullable disable
                        );
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(63, "\r\n        ");
                }
                , 64, (__builder3) => {
                    __builder3.AddMarkupContent(65, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudTablePager>(66);
                    __builder3.AddAttribute(67, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 36 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                            new int[] { 50, 100 }

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(68, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(69, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudDivider>(70);
                __builder2.AddAttribute(71, "Vertical", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "FlexItem", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 40 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                          true

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(73, "\r\n\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudCard>(74);
                __builder2.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(76, "\r\n        \r\n");
#nullable restore
#line 44 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
         if (transactions != null && transactions.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(77, "            ");
                    __Blazor.BlazorServerApp.Pages.Student_.TypeInference.CreateMudTable_1(__builder3, 78, 79, 
#nullable restore
#line 46 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                              transactionSummary

#line default
#line hidden
#nullable disable
                    , 80, "350px", 81, 
#nullable restore
#line 48 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                  Breakpoint.Sm

#line default
#line hidden
#nullable disable
                    , 82, 
#nullable restore
#line 49 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                              hover

#line default
#line hidden
#nullable disable
                    , 83, (__builder4) => {
                        __builder4.AddMarkupContent(84, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(85);
                        __builder4.AddAttribute(86, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(87, "GLACCTNO");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(88, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(89);
                        __builder4.AddAttribute(90, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(91, "Credit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(92, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTh>(93);
                        __builder4.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(95, "Debit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(96, "\r\n                ");
                    }
                    , 97, (context) => (__builder4) => {
                        __builder4.AddMarkupContent(98, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(99);
                        __builder4.AddAttribute(100, "DataLabel", "GLACCTNO");
                        __builder4.AddAttribute(101, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(102, 
#nullable restore
#line 56 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                 context.GLACCTNO

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(103, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(104);
                        __builder4.AddAttribute(105, "DataLabel", "Credit");
                        __builder4.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(107, 
#nullable restore
#line 57 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                               context.TotalCreditAmount

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(108, "\r\n                    ");
                        __builder4.OpenComponent<MudBlazor.MudTd>(109);
                        __builder4.AddAttribute(110, "DataLabel", "Debit");
                        __builder4.AddAttribute(111, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(112, 
#nullable restore
#line 58 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                              context.TotalDebitAmount

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(113, "\r\n                ");
                    }
                    );
                    __builder3.AddMarkupContent(114, "\r\n");
#nullable restore
#line 61 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(115, "            ");
                    __builder3.OpenComponent<MudBlazor.MudPaper>(116);
                    __builder3.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(118, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCard>(119);
                        __builder4.AddAttribute(120, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(121, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(122);
                            __builder5.AddAttribute(123, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(124, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudText>(125);
                                __builder6.AddAttribute(126, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(127, "Transaction Summary Data Not Available!");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(128, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(129, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(130, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(131, "\r\n");
#nullable restore
#line 71 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(132, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(133, "\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(134, "\r\n\r\n\r\n");
            __builder.OpenComponent<MudBlazor.MudGrid>(135);
            __builder.AddAttribute(136, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(137, "\r\n    ");
                __builder2.OpenComponent<MudBlazor.MudItem>(138);
                __builder2.AddAttribute(139, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 78 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                 12

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(140, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(141, "\r\n");
#nullable restore
#line 79 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
         if (transactions != null && transactions.Count() > 0)
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(142, "            ");
                    __builder3.OpenComponent<MudBlazor.MudPaper>(143);
                    __builder3.AddAttribute(144, "Class", "d-flex align-center justify-center mud-width-full py-8");
                    __builder3.AddAttribute(145, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(146, "\r\n                ");
                        __Blazor.BlazorServerApp.Pages.Student_.TypeInference.CreateMudTable_2(__builder4, 147, 148, 
#nullable restore
#line 82 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                  transactions

#line default
#line hidden
#nullable disable
                        , 149, "350px", 150, 
#nullable restore
#line 84 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                      Breakpoint.Sm

#line default
#line hidden
#nullable disable
                        , 151, (__builder5) => {
                            __builder5.AddMarkupContent(152, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(153);
                            __builder5.AddAttribute(154, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(155, "Tr #");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(156, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(157);
                            __builder5.AddAttribute(158, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(159, "Student #");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(160, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(161);
                            __builder5.AddAttribute(162, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(163, "GL ACCT NO");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(164, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(165);
                            __builder5.AddAttribute(166, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(167, "Credit");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(168, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTh>(169);
                            __builder5.AddAttribute(170, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(171, "Debit");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(172, "\r\n                    ");
                        }
                        , 173, (context) => (__builder5) => {
                            __builder5.AddMarkupContent(174, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(175);
                            __builder5.AddAttribute(176, "DataLabel", "TransactionId");
                            __builder5.AddAttribute(177, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(178, 
#nullable restore
#line 93 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                          context.TransactionId

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(179, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(180);
                            __builder5.AddAttribute(181, "DataLabel", "StudentId");
                            __builder5.AddAttribute(182, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(183, 
#nullable restore
#line 94 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                      context.StudentId

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(184, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(185);
                            __builder5.AddAttribute(186, "DataLabel", "GLACCTNO");
                            __builder5.AddAttribute(187, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(188, 
#nullable restore
#line 95 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                     context.GLACCTNO

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(189, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(190);
                            __builder5.AddAttribute(191, "DataLabel", "CreditAmount");
                            __builder5.AddAttribute(192, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(193, 
#nullable restore
#line 96 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                         context.CreditAmount

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(194, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTd>(195);
                            __builder5.AddAttribute(196, "DataLabel", "DebitAmount");
                            __builder5.AddAttribute(197, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddContent(198, 
#nullable restore
#line 97 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                        context.DebitAmount

#line default
#line hidden
#nullable disable
                                );
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(199, "\r\n                    ");
                        }
                        , 200, (__builder5) => {
                            __builder5.AddMarkupContent(201, "\r\n                        ");
                            __builder5.OpenComponent<MudBlazor.MudTablePager>(202);
                            __builder5.AddAttribute(203, "PageSizeOptions", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32[]>(
#nullable restore
#line 100 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
                                                        new int[] { 50, 100 }

#line default
#line hidden
#nullable disable
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(204, "\r\n                    ");
                        }
                        );
                        __builder4.AddMarkupContent(205, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(206, "\r\n");
#nullable restore
#line 104 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(207, "            ");
                    __builder3.OpenComponent<MudBlazor.MudPaper>(208);
                    __builder3.AddAttribute(209, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(210, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudCard>(211);
                        __builder4.AddAttribute(212, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(213, "\r\n                    ");
                            __builder5.OpenComponent<MudBlazor.MudCardContent>(214);
                            __builder5.AddAttribute(215, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(216, "\r\n                        ");
                                __builder6.OpenComponent<MudBlazor.MudText>(217);
                                __builder6.AddAttribute(218, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddContent(219, "Student-Transactions Data Not Available!");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(220, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(221, "\r\n                ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(222, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(223, "\r\n");
#nullable restore
#line 114 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(224, "    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(225, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\BlazorApps\BlazorServerApp\WebApplication1\Pages\Student_.razor"
      

    private bool hover = true;
    private HashSet<Student> selectedStudents = new HashSet<Student>();
    private HashSet<int> selectedIds = new HashSet<int>();

    private Student student = new Student();
    private List<Student> students = new List<Student>();
    public List<Transaction> transactions = new List<Transaction>();
    List<TransactionSummary> transactionSummary = new List<TransactionSummary>();


    protected override async Task OnInitializedAsync()
    {
        GetStudents();
    }
    private List<Student> GetStudents()
    {
        students = studentService.GetStudents();

        return students;
    }
    private Student GetStudent(int id)
    {
        student = studentService.GetStudent(id);

        return student;
    }
    private string HandleNull(string value)
    {
        if (value == null || value == "")
            return "N/A";
        else
            return value;
    }


    private void ClickEvent(Student model)
    {
        // transaction-summary for all selected-students
        selectedIds = new HashSet<int>();
        foreach (var s in selectedStudents)
        {
            selectedIds.Add(s.StudentId);
        }
        List<int> selectedIdsOfList = selectedIds.ToList();
        transactionSummary = studentService.GetTransactionsSummary(selectedIdsOfList);

        transactions = new List<Transaction>();
        GetStudentTransactions(model);
    }
    private List<Transaction> GetStudentTransactions(Student model)
    {
        if (model != null)
        {
            transactions = studentService.GetStudentTransactions(model.StudentId);
            return transactions;
        }
        else
        {
            return new List<Transaction>();
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private MudBlazor.ISnackbar snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataAccess.Contracts.IStudentService studentService { get; set; }
    }
}
namespace __Blazor.BlazorServerApp.Pages.Student_
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::MudBlazor.Breakpoint __arg3, int __seq4, global::System.Boolean __arg4, int __seq5, global::System.Boolean __arg5, int __seq6, global::System.Collections.Generic.HashSet<T> __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<global::System.Collections.Generic.HashSet<T>> __arg7, int __seq8, global::Microsoft.AspNetCore.Components.RenderFragment __arg8, int __seq9, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg9, int __seq10, global::Microsoft.AspNetCore.Components.RenderFragment __arg10)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.AddAttribute(__seq2, "Height", __arg2);
        __builder.AddAttribute(__seq3, "Breakpoint", __arg3);
        __builder.AddAttribute(__seq4, "MultiSelection", __arg4);
        __builder.AddAttribute(__seq5, "Hover", __arg5);
        __builder.AddAttribute(__seq6, "SelectedItems", __arg6);
        __builder.AddAttribute(__seq7, "SelectedItemsChanged", __arg7);
        __builder.AddAttribute(__seq8, "HeaderContent", __arg8);
        __builder.AddAttribute(__seq9, "RowTemplate", __arg9);
        __builder.AddAttribute(__seq10, "PagerContent", __arg10);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Height", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "Hover", __arg3);
        __builder.AddAttribute(__seq4, "HeaderContent", __arg4);
        __builder.AddAttribute(__seq5, "RowTemplate", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateMudTable_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::System.String __arg1, int __seq2, global::MudBlazor.Breakpoint __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "Height", __arg1);
        __builder.AddAttribute(__seq2, "Breakpoint", __arg2);
        __builder.AddAttribute(__seq3, "HeaderContent", __arg3);
        __builder.AddAttribute(__seq4, "RowTemplate", __arg4);
        __builder.AddAttribute(__seq5, "PagerContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\user\source\repos\Blazor_1\Blazor_1\Pages\BookDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd8f698597554aaa624689807127a6d6adda8798"
// <auto-generated/>
#pragma warning disable 1591
namespace Blazor_1.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Blazor_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\source\repos\Blazor_1\Blazor_1\_Imports.razor"
using Blazor_1.Shared;

#line default
#line hidden
#nullable disable
    public partial class BookDetail : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BookDetail</h3>\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Book Name:");
#nullable restore
#line 2 "C:\Users\user\source\repos\Blazor_1\Blazor_1\Pages\BookDetail.razor"
__builder.AddContent(3, BookName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "p");
            __builder.AddContent(6, "Count:");
#nullable restore
#line 3 "C:\Users\user\source\repos\Blazor_1\Blazor_1\Pages\BookDetail.razor"
__builder.AddContent(7, Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n");
            __builder.OpenElement(9, "button");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\user\source\repos\Blazor_1\Blazor_1\Pages\BookDetail.razor"
                  click

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddContent(12, "Save");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\user\source\repos\Blazor_1\Blazor_1\Pages\BookDetail.razor"
       
    [Parameter]
    public string BookName { get; set; }
    [Parameter]
    public int Count { get; set; }

    [Parameter]
    public EventCallback<MouseEventArgs> click { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

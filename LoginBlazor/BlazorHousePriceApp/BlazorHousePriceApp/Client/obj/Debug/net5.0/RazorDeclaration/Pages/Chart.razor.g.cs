// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorHousePriceApp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chart")]
    public partial class Chart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "C:\Users\Florentin\Documents\GitHub\.NET\LoginBlazor\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Chart.razor"
      
    object[] data = new object[] {
        new  { year= "1991", value= 3 },
        new  { year= "1992", value= 4 },
        new  { year= "1993", value= 3.5 },
        new  { year= "1994", value= 5 },
        new  { year= "1995", value= 4.9 },
        new  { year= "1996", value= 6 },
        new  { year= "1997", value= 7 },
        new  { year= "1998", value= 9 },
        new  { year= "1999", value= 13 },
    };

    LineConfig config = new LineConfig()
    {
        Title = new Title()
        {
            Visible = true,
            Text = "曲线折线图",
        },
        Description = new Description()
        {
            Visible = true,
            Text = "用平滑的曲线代替折线。",
        },
        Padding = "auto",
        ForceFit = true,
        XField = "year",
        YField = "value",
        Smooth = true,
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

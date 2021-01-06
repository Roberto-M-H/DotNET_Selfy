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
#line 1 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/texaslateststats")]
    public partial class TexasLatestStats : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 60 "C:\Users\Florentin\Desktop\NET\Curs12\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\TexasLatestStats.razor"
       

    private TexasStatistics stats;

    private string apiUrl = "http://localhost:5000/api/v1/statistica/Texas";

    protected override async Task OnInitializedAsync()
    {
        stats = await Http.GetFromJsonAsync<TexasStatistics>(apiUrl);
    }

    public class TexasStatistics
    {
        public double price { get; set; }
        public double grade { get; set; }
        public double sqftLot { get; set; }
        public double maxPrice { get; set; }
        public double minPrice { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
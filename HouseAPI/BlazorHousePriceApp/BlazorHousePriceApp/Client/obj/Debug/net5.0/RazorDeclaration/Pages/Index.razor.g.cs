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
#line 1 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorHousePriceApp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\_Imports.razor"
using AntDesign.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
using BlazorHousePriceApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
       
    int zoom = 1;
    bool showMadridMarker;
    City T = new City();
    City M = new City();


    protected async override Task OnInitializedAsync()
    {
        T.Type = CityType.Texas;
        M.Type = CityType.Melbourne;

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93a45aab46e1b63de5f367f3b3b34f80b07399b7"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Welcome!</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This is Sims 3\'s HousePriceApp. Predict house prices in available locations and visualize engaging charts regarding prices.</p>\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-xl-6");
            __builder.AddMarkupContent(6, "<h3></h3>\r\n        ");
            __builder.OpenComponent<Radzen.Blazor.RadzenGoogleMap>(7);
            __builder.AddAttribute(8, "style", "height: 400px");
            __builder.AddAttribute(9, "Zoom", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Double>(
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
                                                     zoom

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "Center", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
                                                                   new GoogleMapPosition() { Lat = 42.6977, Lng = 23.3219 }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "Markers", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(12);
                __builder2.AddAttribute(13, "Title", "Texas");
                __builder2.AddAttribute(14, "Label", "Texas");
                __builder2.AddAttribute(15, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 13 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
                                                                              new GoogleMapPosition() { Lat = T.GetLat(), Lng = T.GetLong() }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(16, "\r\n                ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenGoogleMapMarker>(17);
                __builder2.AddAttribute(18, "Title", "Melbourne ");
                __builder2.AddAttribute(19, "Label", "Melbourne");
                __builder2.AddAttribute(20, "Position", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Radzen.GoogleMapPosition>(
#nullable restore
#line 14 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
                                                                                       new GoogleMapPosition() { Lat = M.GetLat(), Lng = M.GetLong() }

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\Index.razor"
       
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

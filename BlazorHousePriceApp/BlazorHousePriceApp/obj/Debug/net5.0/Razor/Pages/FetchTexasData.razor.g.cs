#pragma checksum "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "01863f770eea4dcacd7e3e46643ea2e088880ec3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorHousePriceApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorHousePriceApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorHousePriceApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using BlazorPro.Spinkit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/statisticsdata")]
    public partial class FetchTexasData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Statistics Data</h3>");
#nullable restore
#line 7 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
 if (houses == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BlazorPro.Spinkit.Wave>(1);
            __builder.AddAttribute(2, "Size", "70px");
            __builder.CloseComponent();
#nullable restore
#line 10 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>City</th>\r\n                <th>Price</th>\r\n                <th>Grade</th>\r\n                <th>SqftLot</th>\r\n                <th>MaxPrice</th>\r\n                <th>MinPrice</th>\r\n                <th>Date</th></tr></thead>\r\n        ");
            __builder.OpenElement(6, "tbody");
#nullable restore
#line 26 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
             foreach (var house in houses)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(7, "tr");
            __builder.OpenElement(8, "th");
            __builder.AddContent(9, 
#nullable restore
#line 29 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.NumeOras

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "th");
            __builder.AddContent(12, 
#nullable restore
#line 30 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.MediaPret

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "th");
            __builder.AddContent(15, 
#nullable restore
#line 31 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.MediaRating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "th");
            __builder.AddContent(18, 
#nullable restore
#line 32 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.MediaSuprafata

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "th");
            __builder.AddContent(21, 
#nullable restore
#line 33 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.MaxPret

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "th");
            __builder.AddContent(24, 
#nullable restore
#line 34 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.MinPret

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "th");
            __builder.AddContent(27, 
#nullable restore
#line 35 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
                     house.DateOfStatistic

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "E:\.NET\BlazorHousePriceApp\BlazorHousePriceApp\Pages\FetchTexasData.razor"
       
    private Statistics[] houses;

    private string apiUrl = "http://localhost:5000/api/v1/statistica";

    protected override async Task OnInitializedAsync()
    {
        houses = await Http.GetFromJsonAsync<Statistics[]>(apiUrl);
    }

    public class Statistics
    {
        public string NumeOras { get; set; }
        public double? MediaPret { get; set; }
        public double? MediaSuprafata { get; set; }
        public double? MediaRating { get; set; }
        public double? MaxPret { get; set; }
        public double? MinPret { get; set; }
        public DateTime DateOfStatistic { get; set; }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591

#pragma checksum "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91d686d28e2036796545a05b1021e8edb3ea6211"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/inserthouse")]
    public partial class InsertHouse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Insert a House</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "col-12");
            __builder.AddMarkupContent(3, "<h3><b>Enter House Information</b></h3>\r\n    <hr>\r\n\r\n    ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(4);
            __builder.AddAttribute(5, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                      house

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                             InsertAHouse

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "col-12 row");
                __builder2.AddMarkupContent(14, "<label class=\"col-2 font-weight-bold\">Id :</label>\r\n            ");
                __builder2.OpenElement(15, "input");
                __builder2.AddAttribute(16, "type", "number");
                __builder2.AddAttribute(17, "class", "form-control col-3");
                __builder2.AddAttribute(18, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Id

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(19, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Id = __value, house.Id, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-12 row");
                __builder2.AddMarkupContent(23, "<label class=\"col-2 font-weight-bold\">Date :</label>\r\n            ");
                __builder2.OpenElement(24, "input");
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "class", "form-control col-3");
                __builder2.AddAttribute(27, "placeholder", "string");
                __builder2.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                 house.Date

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Date = __value, house.Date));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-12 row");
                __builder2.AddMarkupContent(33, "<label class=\"col-2 font-weight-bold\">Price :</label>\r\n            ");
                __builder2.OpenElement(34, "input");
                __builder2.AddAttribute(35, "type", "number");
                __builder2.AddAttribute(36, "class", "form-control col-3");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Price

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Price = __value, house.Price, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-12 row");
                __builder2.AddMarkupContent(42, "<label class=\"col-2 font-weight-bold\">Bedrooms :</label>\r\n            ");
                __builder2.OpenElement(43, "input");
                __builder2.AddAttribute(44, "type", "number");
                __builder2.AddAttribute(45, "class", "form-control col-3");
                __builder2.AddAttribute(46, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Bedrooms

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(47, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Bedrooms = __value, house.Bedrooms, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "col-12 row");
                __builder2.AddMarkupContent(51, "<label class=\"col-2 font-weight-bold\">Bathrooms :</label>\r\n            ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "number");
                __builder2.AddAttribute(54, "class", "form-control col-3");
                __builder2.AddAttribute(55, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Bathrooms

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(56, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Bathrooms = __value, house.Bathrooms, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(57, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "col-12 row");
                __builder2.AddMarkupContent(60, "<label class=\"col-2 font-weight-bold\">SqftLiving :</label>\r\n            ");
                __builder2.OpenElement(61, "input");
                __builder2.AddAttribute(62, "type", "number");
                __builder2.AddAttribute(63, "class", "form-control col-3");
                __builder2.AddAttribute(64, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftLiving

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(65, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftLiving = __value, house.SqftLiving, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n            ");
                __Blazor.BlazorHousePriceApp.Client.Pages.InsertHouse.TypeInference.CreateValidationMessage_0(__builder2, 67, 68, 
#nullable restore
#line 42 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                      ()=> house.SqftLiving

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "col-12 row");
                __builder2.AddMarkupContent(72, "<label class=\"col-2 font-weight-bold\">SqftLot :</label>\r\n            ");
                __builder2.OpenElement(73, "input");
                __builder2.AddAttribute(74, "type", "number");
                __builder2.AddAttribute(75, "class", "form-control col-3");
                __builder2.AddAttribute(76, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 47 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftLot

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(77, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftLot = __value, house.SqftLot, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(78, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(79, "div");
                __builder2.AddAttribute(80, "class", "col-12 row");
                __builder2.AddMarkupContent(81, "<label class=\"col-2 font-weight-bold\">Floors :</label>\r\n            ");
                __builder2.OpenElement(82, "input");
                __builder2.AddAttribute(83, "type", "number");
                __builder2.AddAttribute(84, "class", "form-control col-3");
                __builder2.AddAttribute(85, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Floors

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(86, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Floors = __value, house.Floors, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "col-12 row");
                __builder2.AddMarkupContent(90, "<label class=\"col-2 font-weight-bold\">Waterfront :</label>\r\n            ");
                __builder2.OpenElement(91, "input");
                __builder2.AddAttribute(92, "type", "number");
                __builder2.AddAttribute(93, "class", "form-control col-3");
                __builder2.AddAttribute(94, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 57 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Waterfront

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(95, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Waterfront = __value, house.Waterfront, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "col-12 row");
                __builder2.AddMarkupContent(99, "<label class=\"col-2 font-weight-bold\">View :</label>\r\n            ");
                __builder2.OpenElement(100, "input");
                __builder2.AddAttribute(101, "type", "number");
                __builder2.AddAttribute(102, "class", "form-control col-3");
                __builder2.AddAttribute(103, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 62 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.View

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(104, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.View = __value, house.View, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(106, "div");
                __builder2.AddAttribute(107, "class", "col-12 row");
                __builder2.AddMarkupContent(108, "<label class=\"col-2 font-weight-bold\">Condition :</label>\r\n            ");
                __builder2.OpenElement(109, "input");
                __builder2.AddAttribute(110, "type", "number");
                __builder2.AddAttribute(111, "class", "form-control col-3");
                __builder2.AddAttribute(112, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 67 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Condition

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(113, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Condition = __value, house.Condition, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-12 row");
                __builder2.AddMarkupContent(117, "<label class=\"col-2 font-weight-bold\">Grade :</label>\r\n            ");
                __builder2.OpenElement(118, "input");
                __builder2.AddAttribute(119, "type", "number");
                __builder2.AddAttribute(120, "class", "form-control col-3");
                __builder2.AddAttribute(121, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 72 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Grade

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(122, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Grade = __value, house.Grade, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "col-12 row");
                __builder2.AddMarkupContent(126, "<label class=\"col-2 font-weight-bold\">SqftAbove :</label>\r\n            ");
                __builder2.OpenElement(127, "input");
                __builder2.AddAttribute(128, "type", "number");
                __builder2.AddAttribute(129, "class", "form-control col-3");
                __builder2.AddAttribute(130, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 77 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftAbove

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(131, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftAbove = __value, house.SqftAbove, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(133, "div");
                __builder2.AddAttribute(134, "class", "col-12 row");
                __builder2.AddMarkupContent(135, "<label class=\"col-2 font-weight-bold\">SqftBasement :</label>\r\n            ");
                __builder2.OpenElement(136, "input");
                __builder2.AddAttribute(137, "type", "number");
                __builder2.AddAttribute(138, "class", "form-control col-3");
                __builder2.AddAttribute(139, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 82 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftBasement

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(140, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftBasement = __value, house.SqftBasement, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "col-12 row");
                __builder2.AddMarkupContent(144, "<label class=\"col-2 font-weight-bold\">YrBuilt :</label>\r\n            ");
                __builder2.OpenElement(145, "input");
                __builder2.AddAttribute(146, "type", "number");
                __builder2.AddAttribute(147, "class", "form-control col-3");
                __builder2.AddAttribute(148, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 87 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.YrBuilt

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(149, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.YrBuilt = __value, house.YrBuilt, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(150, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(151, "div");
                __builder2.AddAttribute(152, "class", "col-12 row");
                __builder2.AddMarkupContent(153, "<label class=\"col-2 font-weight-bold\">YrRenovated :</label>\r\n            ");
                __builder2.OpenElement(154, "input");
                __builder2.AddAttribute(155, "type", "number");
                __builder2.AddAttribute(156, "class", "form-control col-3");
                __builder2.AddAttribute(157, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 92 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.YrRenovated

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(158, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.YrRenovated = __value, house.YrRenovated, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(159, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(160, "div");
                __builder2.AddAttribute(161, "class", "col-12 row");
                __builder2.AddMarkupContent(162, "<label class=\"col-2 font-weight-bold\">Zipcode :</label>\r\n            ");
                __builder2.OpenElement(163, "input");
                __builder2.AddAttribute(164, "type", "number");
                __builder2.AddAttribute(165, "class", "form-control col-3");
                __builder2.AddAttribute(166, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 97 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Zipcode

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(167, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Zipcode = __value, house.Zipcode, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(168, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(169, "div");
                __builder2.AddAttribute(170, "class", "col-12 row");
                __builder2.AddMarkupContent(171, "<label class=\"col-2 font-weight-bold\">Lat :</label>\r\n            ");
                __builder2.OpenElement(172, "input");
                __builder2.AddAttribute(173, "type", "number");
                __builder2.AddAttribute(174, "class", "form-control col-3");
                __builder2.AddAttribute(175, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 102 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Lat

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(176, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Lat = __value, house.Lat, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(177, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(178, "div");
                __builder2.AddAttribute(179, "class", "col-12 row");
                __builder2.AddMarkupContent(180, "<label class=\"col-2 font-weight-bold\">Long :</label>\r\n            ");
                __builder2.OpenElement(181, "input");
                __builder2.AddAttribute(182, "type", "number");
                __builder2.AddAttribute(183, "class", "form-control col-3");
                __builder2.AddAttribute(184, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 107 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.Long

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(185, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.Long = __value, house.Long, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(186, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(187, "div");
                __builder2.AddAttribute(188, "class", "col-12 row");
                __builder2.AddMarkupContent(189, "<label class=\"col-2 font-weight-bold\">SqftLiving15 :</label>\r\n            ");
                __builder2.OpenElement(190, "input");
                __builder2.AddAttribute(191, "type", "number");
                __builder2.AddAttribute(192, "class", "form-control col-3");
                __builder2.AddAttribute(193, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 112 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftLiving15

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(194, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftLiving15 = __value, house.SqftLiving15, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(195, "\r\n        <br>\r\n        ");
                __builder2.OpenElement(196, "div");
                __builder2.AddAttribute(197, "class", "col-12 row");
                __builder2.AddMarkupContent(198, "<label class=\"col-2 font-weight-bold\">SqftLot15 :</label>\r\n            ");
                __builder2.OpenElement(199, "input");
                __builder2.AddAttribute(200, "type", "number");
                __builder2.AddAttribute(201, "class", "form-control col-3");
                __builder2.AddAttribute(202, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 117 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
                                                                   house.SqftLot15

#line default
#line hidden
#nullable disable
                , culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(203, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => house.SqftLot15 = __value, house.SqftLot15, culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(204, "\r\n        <br>\r\n        \r\n        ");
                __builder2.AddMarkupContent(205, "<div class=\"col-12 row\"><span class=\"col-2\"></span>\r\n            <input type=\"submit\" class=\"form-control col-1 btn btn-primary\" value=\"Insert\"></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 130 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
 if (inserted == false)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(206, "<p><em>Please fill in the house data...</em></p>");
#nullable restore
#line 133 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(207, "<h3>House Inserted</h3>");
#nullable restore
#line 137 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 143 "C:\Users\Florentin\Documents\GitHub\.NET\HouseAPI\BlazorHousePriceApp\BlazorHousePriceApp\Client\Pages\InsertHouse.razor"
       



    public Data.Texa house { get; set; }
    public bool inserted = false;

    string result;

    public HttpResponseMessage response { get; set; }

    private string apiUrl = "https://localhost:44332/api/v1/inserttexas";

    protected async override Task OnInitializedAsync()
    {
        house = new Data.Texa();

    }

    private async Task InsertAHouse()

    {
        inserted = false;
        response = await Http.PostAsJsonAsync(apiUrl, house);
        house = new Data.Texa();
        inserted = true;
    }


    /*

    var httpclient = new HttpClient();
            var response = await httpclient.GetAsync(apiUrl);
            string responseAsString = response.Content.ReadAsStringAsync().Result;
            var statistics = System.Text.Json.JsonSerializer.Deserialize<TexasStatistics>(responseAsString);


    */



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
namespace __Blazor.BlazorHousePriceApp.Client.Pages.InsertHouse
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591

using AntDesign.Charts;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorHousePriceApp.Client.Pages
{
    public partial class StatistiscData : ComponentBase
    {
        private Statistics[] houses;
        public List<T> Cities = new List<T>();
        //public List<T> Singapore = new List<T>();

        private string apiUrl = "http://localhost:5000/api/v1/statistics";

        protected override async Task OnInitializedAsync()
        {
            houses = await Http.GetFromJsonAsync<Statistics[]>(apiUrl);
            Cities = Array.ConvertAll(houses.OrderBy(h => h.DateOfStatistic).ToArray(), x => new T(x)).ToList();
            //Singapore = Array.ConvertAll(houses, x => new T(x)).Where(x => x.name.Equals("Singapore")).ToList();
        }

        LineConfig config = new LineConfig()
        {
            Title = new Title()
            {
                Visible = true,
                Text = "Average House Price Evolution",
            },
            Description = new Description()
            {
                Visible = true,
                Text = "X-Axis=Time; Y-Axis=Average House Price Value",
            },
            Padding = "auto",
            ForceFit = true,
            XField = "year",
            YField = "value",
            SeriesField = "name",
            Smooth = true,
            Color = new string[] { "#d62728", "#2ca02c" },
        };


        public class T
        {
            public T(Statistics x)
            {
                name = x.City;
                value = x.Price;
                year = x.DateOfStatistic.ToString("m", CultureInfo.CreateSpecificCulture("en-US"));
            }

            public string name { get; set; }
            public double value { get; set; }
            public string year { get; set; }
        }

        public class Statistics
        {
            public string City { get; set; }
            public double Price { get; set; }
            public double SqftLot { get; set; }
            public double Grade { get; set; }
            public double MaxPrice { get; set; }
            public double MinPrice { get; set; }
            public DateTime DateOfStatistic { get; set; }

        }
    }
}
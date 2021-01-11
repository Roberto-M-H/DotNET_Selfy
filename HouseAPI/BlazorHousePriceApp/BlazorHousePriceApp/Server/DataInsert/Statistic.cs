using System;
using System.Collections.Generic;

#nullable disable

namespace BlazorHousePriceApp.Server.DataInsert
{
    public partial class Statistic
    {
        public string City { get; set; }
        public double? Price { get; set; }
        public double? Sqftlot { get; set; }
        public double? Grade { get; set; }
        public double? MaxPrice { get; set; }
        public double? MinPrice { get; set; }
        public DateTime DateOfStatistic { get; set; }
    }
}

using System;

namespace BlazorHousePriceApp.Data
{
    public class Statistics
    {
        public string City { get; set; }
        public double? Price { get; set; }
        public double? SqftLot { get; set; }
        public double? Grade { get; set; }
        public double? MaxPrice { get; set; }
        public double? MinPrice { get; set; }
        public DateTime DateOfStatistic { get; set; }
    }
}

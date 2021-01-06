using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorHousePriceApp.Data
{
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
}

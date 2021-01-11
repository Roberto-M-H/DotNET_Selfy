using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorHousePriceApp.Data
{
    public partial class Melbourne
    {
        public double Rooms { get; set; }
        public double Price { get; set; }
        public double Distance { get; set; }
        public double Postcode { get; set; }
        public double Bedroom2 { get; set; }
        public double Bathroom { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a Landsize value bigger than {1}")]
        public double Landsize { get; set; }
        public double BuildingArea { get; set; }
        public double YearBuilt { get; set; }
        public string CouncilArea { get; set; }
        public string Regionname { get; set; }
        public string PredictionId { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace BlazorHousePriceApp.Data
{
    public class Texa
    {
        public double Id { get; set; }
        [Required]
        public string Date { get; set; }
        public double Price { get; set; }
        public double Bedrooms { get; set; }
        public double Bathrooms { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a value bigger than {1}")]
        public double SqftLiving { get; set; }
        public double SqftLot { get; set; }
        public double Floors { get; set; }
        public double Waterfront { get; set; }
        public double View { get; set; }
        public double Condition { get; set; }
        public double Grade { get; set; }
        public double SqftAbove { get; set; }
        public double SqftBasement { get; set; }
        public double YrBuilt { get; set; }
        public double YrRenovated { get; set; }
        public double Zipcode { get; set; }
        public double Lat { get; set; }
        public double Long { get; set; }
        public double SqftLiving15 { get; set; }
        public double SqftLot15 { get; set; }
    }
}

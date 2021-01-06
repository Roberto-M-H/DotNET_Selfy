using System;

#nullable disable

namespace HousePriceAPI.Data
{
    public partial class Statistica
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

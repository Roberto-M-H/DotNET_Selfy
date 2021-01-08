#nullable disable

namespace HousePriceAPI.Data
{
    public partial class Melbourne
    {
        public double Rooms { get; set; }
        public double? Price { get; set; }
        public double Distance { get; set; }
        public string Postcode { get; set; }
        public string Bedroom2 { get; set; }
        public double? Bathroom { get; set; }
        public double? Landsize { get; set; }
        public double? BuildingArea { get; set; }
        public double? YearBuilt { get; set; }
        public string CouncilArea { get; set; }
        public string Regionname { get; set; }
        public string PredictionId { get; set; }
    }
}

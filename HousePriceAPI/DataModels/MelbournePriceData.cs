using Microsoft.ML.Data;
namespace HousePriceAPI.DataModels
{
    public class MelbournePriceData
    {
        [ColumnName("Rooms"), LoadColumn(0)]
        public float Rooms { get; set; }


        [ColumnName("Price"), LoadColumn(1)]
        public float Price { get; set; }


        [ColumnName("Distance"), LoadColumn(2)]
        public float Distance { get; set; }


        [ColumnName("Postcode"), LoadColumn(3)]
        public float Postcode { get; set; }


        [ColumnName("Bedroom2"), LoadColumn(4)]
        public float Bedroom2 { get; set; }


        [ColumnName("Bathroom"), LoadColumn(5)]
        public float Bathroom { get; set; }


        [ColumnName("Landsize"), LoadColumn(6)]
        public float Landsize { get; set; }


        [ColumnName("BuildingArea"), LoadColumn(7)]
        public float BuildingArea { get; set; }


        [ColumnName("YearBuilt"), LoadColumn(8)]
        public float YearBuilt { get; set; }


        [ColumnName("CouncilArea"), LoadColumn(9)]
        public string CouncilArea { get; set; }


        [ColumnName("Regionname"), LoadColumn(10)]
        public string Regionname { get; set; }
    }
}

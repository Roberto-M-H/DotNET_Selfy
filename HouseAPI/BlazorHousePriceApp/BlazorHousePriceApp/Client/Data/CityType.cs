using System;
using System.Collections.Generic;
using Ardalis.SmartEnum;

public abstract class CityType : SmartEnum<CityType>
{
    private CityType(string name, int value) : base(name, value) { }

    public List<string> CityNames = new List<string>()
    {
        "Texas",
        "Melbourne"
    };
    public static readonly CityType Texas = new TexasType();
    public static readonly CityType Melbourne = new MelbourneType();

    public abstract double CalculateLatestStatsChartMaxValue(double amount);
    public abstract double CalculateLatestStatsChartGreenValue(double amount);
    public abstract double CalculateLatestStatsChartOrangeValue(double amount);
    public abstract double CalculateLatestStatsChartRedValue(double amount);
    public abstract double CalculateLat();
    public abstract double CalculateLong();

    private sealed class TexasType : CityType
    {
        public TexasType() : base("Texas", 1) { }

        private const int TexasLatestStatsChartMaxValue = 10000;
        private const int TexasLatestStatsChartGreenValue = 30000;
        private const int TexasLatestStatsChartOrangeValue = 15000;
        private const int TexasLatestStatsChartRedValue = 10000;
        private const double TexasLat = 33.61;
        private const double TexasLong = -100.25;

        public override double CalculateLatestStatsChartMaxValue(double price) => price / TexasLatestStatsChartMaxValue;
        public override double CalculateLatestStatsChartGreenValue(double price) => price / TexasLatestStatsChartGreenValue;
        public override double CalculateLatestStatsChartOrangeValue(double price) => price / TexasLatestStatsChartOrangeValue;
        public override double CalculateLatestStatsChartRedValue(double price) => price / TexasLatestStatsChartRedValue;

        public override double CalculateLat() => TexasLat;
        public override double CalculateLong() => TexasLong;
    }

    private sealed class MelbourneType : CityType
    {

        public MelbourneType() : base("Merbourne", 2) { }

        private const int MerbourneLatestStatsChartMaxValue = 5000;
        private const int MerbourneLatestStatsChartGreenValue = 30000;
        private const int MerbourneLatestStatsChartOrangeValue = 15000;
        private const int MerbourneLatestStatsChartRedValue = 10000;

        private const double MelbourneLat = -37.814;
        private const double MelbourneLong = 144.96332;

        public override double CalculateLatestStatsChartMaxValue(double price) => price / MerbourneLatestStatsChartMaxValue;
        public override double CalculateLatestStatsChartGreenValue(double price) => price / MerbourneLatestStatsChartGreenValue;
        public override double CalculateLatestStatsChartOrangeValue(double price) => price / MerbourneLatestStatsChartOrangeValue;
        public override double CalculateLatestStatsChartRedValue(double price) => price / MerbourneLatestStatsChartRedValue;

        public override double CalculateLat() => MelbourneLat;
        public override double CalculateLong() => MelbourneLong;
    }
}
public class City
{
    public CityType Type { get; set; }

    public double GetLat()
    {
        return Type.CalculateLat();
    }

    public double GetLong()
    {
        return Type.CalculateLong();
    }

    public double CalculateChartMaxValues(double amount)
    {
        return Type.CalculateLatestStatsChartMaxValue(amount);
    }

    public double CalculateChartGreenValues(double amount)
    {
        return Type.CalculateLatestStatsChartGreenValue(amount);
    }

    public double CalculateChartOrangeValues(double amount)
    {
        return Type.CalculateLatestStatsChartOrangeValue(amount);
    }

    public double CalculateChartRedValues(double amount)
    {
        return Type.CalculateLatestStatsChartRedValue(amount);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherResultDto
    {
        public string Key { get; set; }
        public string LocalizedName { get; set; }
        public string EnglishName { get; set; }
        public string City { get; set; }
        public int Degrees { get; set; }
        public string Localized { get; set; }
        public string English { get; set; }
        public int Value { get; set; }
        public string Unit { get; set; }
        public int UnitType { get; set; }
        public string Phrase { get; set; }
        public Minimum Minimum { get; set; }
        public Maximum Maximum { get; set; }
        public Precipitation Precipitation { get; set; }
        public PastHour PastHour { get; set; }
        public Past3Hours Past3Hours { get; set; }
        public Past6Hours Past6Hours { get; set; }
        public Past9Hours Past9Hours { get; set; }
        public Past12Hours Past12Hours { get; set; }
        public Past18Hours Past18Hours { get; set; }
        public Past24Hours Past24Hours { get; set; }
        public string LocalizedText { get; set; }
        public string Code { get; set; }
        public string LocalObservationDateTime { get; set; }
        public int EpochTime { get; set; }
        public string WeatherText { get; set; }
        public int WeatherIcon { get; set; }
        public bool HasPrecipitation { get; set; }
        public object PrecipitationType { get; set; }
        public bool IsDayTime { get; set; }
        public double Temperature { get; set; }
        public double RealFeelTemperature { get; set; }
        public RealFeelTemperatureShade RealFeelTemperatureShade { get; set; }
        public int RelativeHumidity { get; set; }
        public int IndoorRelativeHumidity { get; set; }
        public DewPoint DewPoint { get; set; }
        public double Wind { get; set; }
        public double WindSpeed { get; set; }
        public WindGust WindGust { get; set; }
        public int UVIndex { get; set; }
        public string UVIndexText { get; set; }
        public Visibility Visibility { get; set; }
        public string ObstructionsToVisibility { get; set; }
        public int CloudCover { get; set; }
        public double Pressure { get; set; }
        public PressureTendency PressureTendency { get; set; }
        public Past24HourTemperatureDeparture Past24HourTemperatureDeparture { get; set; }
        public WindChillTemperature WindChillTemperature { get; set; }
        public WetBulbTemperature WetBulbTemperature { get; set; }
        public Precip1hr Precip1hr { get; set; }
        public PrecipitationSummary PrecipitationSummary { get; set; }
        public TemperatureSummary TemperatureSummary { get; set; }
        public Past6HourRange Past6HourRange { get; set; }
        public Past24HourRange Past24HourRange { get; set; }
        public Metric Metric { get; set; }
        public Imperial Imperial { get; set; }
        public Direction Direction { get; set; }
        public Ceiling Ceiling { get; set; }

    }
}

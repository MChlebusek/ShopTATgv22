using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Shop.Core.Dto.AccuWeatherDtos
{
    public class AccuWeatherRootDto

    {
        [JsonPropertyName("Key")]
        public string Key { get; set; }

        [JsonPropertyName("LocalizedName")]
        public string LocalizedName { get; set; }

        [JsonPropertyName("EnglishName")]
        public string EnglishName { get; set; }

        [JsonPropertyName("LocalObservationDateTime")]
        public DateTime LocalObservationDateTime { get; set; }

        [JsonPropertyName("EpochTime")]
        public int EpochTime { get; set; }

        [JsonPropertyName("WeatherText")]
        public string WeatherText { get; set; }

        [JsonPropertyName("WeatherIcon")]
        public int WeatherIcon { get; set; }

        [JsonPropertyName("HasPrecipitation")]
        public bool HasPrecipitation { get; set; }

        [JsonPropertyName("PrecipitationType")]
        public object PrecipitationType { get; set; }

        [JsonPropertyName("IsDayTime")]
        public bool IsDayTime { get; set; }

        [JsonPropertyName("Temperature")]
        public Temperature Temperature { get; set; }

        [JsonPropertyName("RealFeelTemperature")]
        public RealFeelTemperature RealFeelTemperature { get; set; }

        [JsonPropertyName("RealFeelTemperatureShade")]
        public RealFeelTemperatureShade RealFeelTemperatureShade { get; set; }

        [JsonPropertyName("RelativeHumidity")]
        public int RelativeHumidity { get; set; }

        [JsonPropertyName("IndoorRelativeHumidity")]
        public int IndoorRelativeHumidity { get; set; }

        [JsonPropertyName("DewPoint")]
        public DewPoint DewPoint { get; set; }

        [JsonPropertyName("Wind")]
        public Wind Wind { get; set; }

        [JsonPropertyName("WindGust")]
        public WindGust WindGust { get; set; }

        [JsonPropertyName("UVIndex")]
        public int UVIndex { get; set; }

        [JsonPropertyName("UVIndexText")]
        public string UVIndexText { get; set; }

        [JsonPropertyName("Visibility")]
        public Visibility Visibility { get; set; }

        [JsonPropertyName("ObstructionsToVisibility")]
        public string ObstructionsToVisibility { get; set; }

        [JsonPropertyName("CloudCover")]
        public int CloudCover { get; set; }

        [JsonPropertyName("Ceiling")]
        public Ceiling Ceiling { get; set; }

        [JsonPropertyName("Pressure")]
        public Pressure Pressure { get; set; }

        [JsonPropertyName("PressureTendency")]
        public PressureTendency PressureTendency { get; set; }

        [JsonPropertyName("Past24HourTemperatureDeparture")]
        public Past24HourTemperatureDeparture Past24HourTemperatureDeparture { get; set; }

        [JsonPropertyName("ApparentTemperature")]
        public ApparentTemperature ApparentTemperature { get; set; }

        [JsonPropertyName("WindChillTemperature")]
        public WindChillTemperature WindChillTemperature { get; set; }

        [JsonPropertyName("WetBulbTemperature")]
        public WetBulbTemperature WetBulbTemperature { get; set; }

        [JsonPropertyName("Precip1hr")]
        public Precip1hr Precip1hr { get; set; }

        [JsonPropertyName("PrecipitationSummary")]
        public PrecipitationSummary PrecipitationSummary { get; set; }

        [JsonPropertyName("TemperatureSummary")]
        public TemperatureSummary TemperatureSummary { get; set; }
    }
    public class ApparentTemperature
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Ceiling
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class DewPoint
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Direction
    {
        [JsonPropertyName("Degrees")]
        public int Degrees { get; set; }

        [JsonPropertyName("Localized")]
        public string Localized { get; set; }

        [JsonPropertyName("English")]
        public string English { get; set; }
    }

    public class Imperial
    {
        [JsonPropertyName("Value")]
        public int Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }

        [JsonPropertyName("Phrase")]
        public string Phrase { get; set; }
    }

    public class Maximum
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Metric
    {
        [JsonPropertyName("Value")]
        public double Value { get; set; }

        [JsonPropertyName("Unit")]
        public string Unit { get; set; }

        [JsonPropertyName("UnitType")]
        public int UnitType { get; set; }

        [JsonPropertyName("Phrase")]
        public string Phrase { get; set; }
    }

    public class Minimum
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past12HourRange
    {
        [JsonPropertyName("Minimum")]
        public Minimum Minimum { get; set; }

        [JsonPropertyName("Maximum")]
        public Maximum Maximum { get; set; }
    }

    public class Past12Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past18Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past24HourRange
    {
        [JsonPropertyName("Minimum")]
        public Minimum Minimum { get; set; }

        [JsonPropertyName("Maximum")]
        public Maximum Maximum { get; set; }
    }

    public class Past24Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past24HourTemperatureDeparture
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past3Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past6HourRange
    {
        [JsonPropertyName("Minimum")]
        public Minimum Minimum { get; set; }

        [JsonPropertyName("Maximum")]
        public Maximum Maximum { get; set; }
    }

    public class Past6Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Past9Hours
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class PastHour
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Precip1hr
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Precipitation
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class PrecipitationSummary
    {
        [JsonPropertyName("Precipitation")]
        public Precipitation Precipitation { get; set; }

        [JsonPropertyName("PastHour")]
        public PastHour PastHour { get; set; }

        [JsonPropertyName("Past3Hours")]
        public Past3Hours Past3Hours { get; set; }

        [JsonPropertyName("Past6Hours")]
        public Past6Hours Past6Hours { get; set; }

        [JsonPropertyName("Past9Hours")]
        public Past9Hours Past9Hours { get; set; }

        [JsonPropertyName("Past12Hours")]
        public Past12Hours Past12Hours { get; set; }

        [JsonPropertyName("Past18Hours")]
        public Past18Hours Past18Hours { get; set; }

        [JsonPropertyName("Past24Hours")]
        public Past24Hours Past24Hours { get; set; }
    }

    public class Pressure
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class PressureTendency
    {
        [JsonPropertyName("LocalizedText")]
        public string LocalizedText { get; set; }

        [JsonPropertyName("Code")]
        public string Code { get; set; }
    }

    public class RealFeelTemperature
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class RealFeelTemperatureShade
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }



    public class Speed
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Temperature
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class TemperatureSummary
    {
        [JsonPropertyName("Past6HourRange")]
        public Past6HourRange Past6HourRange { get; set; }

        [JsonPropertyName("Past12HourRange")]
        public Past12HourRange Past12HourRange { get; set; }

        [JsonPropertyName("Past24HourRange")]
        public Past24HourRange Past24HourRange { get; set; }
    }

    public class Visibility
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class WetBulbTemperature
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class Wind
    {
        [JsonPropertyName("Direction")]
        public Direction Direction { get; set; }

        [JsonPropertyName("Speed")]
        public Speed Speed { get; set; }
    }

    public class WindChillTemperature
    {
        [JsonPropertyName("Metric")]
        public Metric Metric { get; set; }

        [JsonPropertyName("Imperial")]
        public Imperial Imperial { get; set; }
    }

    public class WindGust
    {
        [JsonPropertyName("Speed")]
        public Speed Speed { get; set; }
    }



}

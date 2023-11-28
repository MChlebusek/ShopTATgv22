using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Nancy.Json;
using Shop.Core.Dto.AccuWeatherDtos;
using Shop.Core.ServiceInterface;

namespace Shop.ApplicationServices.Services
{
    public class AccuWeatherServices : IAccuWeatherServices

    {
        public async Task<AccuWeatherResultDto> AccuWeatherResult(AccuWeatherResultDto dto)
        {
            string locationKey = await GetLocationKey(dto.City);


            if (locationKey != null)
            {

                string apiKey = "Tlvpb0R7udvxl1vXZdTY9rG92fvVSUsk";
                string url = $"http://dataservice.accuweather.com/currentconditions/v1/{locationKey}?apikey={apiKey}&details=true";

                using (WebClient client = new WebClient())

                {
                    string json = client.DownloadString(url);

                    List<AccuWeatherRootDto> weatherResult = new JavaScriptSerializer().Deserialize<List<AccuWeatherRootDto>>(json);

                    dto.Temperature = weatherResult[0].Temperature.Metric.Value;
                    dto.RealFeelTemperature = weatherResult[0].RealFeelTemperature.Metric.Value;
                    dto.RelativeHumidity = weatherResult[0].RelativeHumidity;
                    dto.Pressure = weatherResult[0].Pressure.Metric.Value;
                    dto.WindSpeed = weatherResult[0].Wind.Speed.Metric.Value;
                    dto.WeatherText = weatherResult[0].WeatherText;
                }

                return dto;
            }
            return null;
        }

        public async Task<string> GetLocationKey(string city)
        {
            string apiKey = "Tlvpb0R7udvxl1vXZdTY9rG92fvVSUsk";
            string urlCity = $"http://dataservice.accuweather.com/locations/v1/cities/search?apikey={apiKey}&q={city}";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(urlCity);
                List<AccuWeatherRootDto> locationResults = new JavaScriptSerializer().Deserialize<List<AccuWeatherRootDto>>(json);

                if (locationResults != null)
                {
                    return locationResults[0].Key;
                }

                return null;
            }
        }

    }

}

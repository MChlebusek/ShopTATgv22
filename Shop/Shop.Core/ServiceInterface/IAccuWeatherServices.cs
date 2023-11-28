using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.Core.Dto.AccuWeatherDtos;

namespace Shop.Core.ServiceInterface
{
    public interface IAccuWeatherServices
    {
        Task<AccuWeatherResultDto> AccuWeatherResult(AccuWeatherResultDto dto);

        Task<string> GetLocationKey(string city);


    }
}

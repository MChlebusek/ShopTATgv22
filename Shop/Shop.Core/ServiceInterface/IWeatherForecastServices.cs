﻿using Shop.Core.Dto.OpenWeatherDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Core.ServiceInterface
{
    public interface IWeatherForecastServices
    {

        Task<OpenWeatherResultDto> OpenWeatherResul(OpenWeatherResultDto dto);
    }
}


﻿using Nancy.Json;
using Shop.Core.Dto.ChuckNorrisDtos;
using Shop.Core.ServiceInterface;
using System.Net;

namespace Shop.ApplicationServices.Services
{
    public class ChuckNorrisServices : IChuckNorrisServices
    {
        public async Task<ChuckNorrisResultDto> ChuckNorrisResult(ChuckNorrisResultDto dto)
        {
            var url = "https://api.chucknorris.io/jokes/random";

            using (WebClient client = new WebClient())
            {
                string json = client.DownloadString(url);
                ChuckNorrisRootDto chuckNorrisResult = new JavaScriptSerializer().Deserialize<ChuckNorrisRootDto>(json);


                dto.CreatedAt = DateTime.Now;
                dto.IconUrl = chuckNorrisResult.IconUrl;
                dto.Id = chuckNorrisResult.Id;
                dto.UpdatedAt = DateTime.Now;
                dto.Url = chuckNorrisResult.Url;
                dto.Value = chuckNorrisResult.Value;
            }

            return dto;
        }
    }
}

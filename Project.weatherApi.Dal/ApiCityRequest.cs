using Project.WeatherApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.weatherApi.Dal
{
    public class ApiCityRequest
    {

        public async Task<WeatherModel> GetCityData(string nameCity)
        {

            WeatherModel weather;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.weatherapi.com/");

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage pespones = await client.GetAsync($@"v1/current.json?key=b420de9869b8456bb3a110035222004&q={nameCity}& aqi=no");

                string lines = await pespones.Content.ReadAsStringAsync();

                weather = JsonSerializer.Deserialize<WeatherModel>(lines);

                return weather;

            }


        }

    }
}

using Project.weatherApi.Dal;
using Project.WeatherApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.weatherApi.Entities
{
    public class Lists
    {
        public Dictionary<string, WeatherModel> WeatherTable = new Dictionary<string, WeatherModel>();
        public async Task<Dictionary<string, WeatherModel>>AddUpdateToDictionary(string cityName)
        {

            ApiCityRequest AddCity = new ApiCityRequest();
            var ggg=await AddCity.GetCityData(cityName);
            if (!WeatherTable.ContainsKey(ggg.location.name))
            {
                WeatherTable.Add(ggg.location.name, ggg);

            }
            else
            {
                WeatherTable[ggg.location.name] = ggg;
            }
            return WeatherTable;

        }

        

    }
}

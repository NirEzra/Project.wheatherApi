using Project.weatherApi.Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.weatherApi.Entities
{
    public class Request
    {
        public async Task<float> GetCityTemp(string cityName)
        {

            ApiCityRequest a = new ApiCityRequest();
            var t =await  a.GetCityData(cityName);
            var temp = t.current.temp_c;
            return temp;

        }

    }
}

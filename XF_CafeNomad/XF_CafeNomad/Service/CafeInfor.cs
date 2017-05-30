using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using XF_CafeNomad.Model;
using Newtonsoft.Json;
using System.Net.Http;

namespace XF_CafeNomad.Service
{
    class CafeInfor
    {
        private List<CafeShop> cafeShops;
        private HttpClient httpClient = new HttpClient();
        private string city;

        public CafeInfor(string city = "Not Select")
        {
            this.city = city;
        }
        public async Task<List<CafeShop>> GetShopsAsync()
        {
            string cafeUrl;
            if (city.Equals("Not Select"))
            {
                cafeUrl = Constant.CafenomadUrl;
            }
            else
            {
                cafeUrl = Constant.CafenomadUrl + city;
            }

            var response = await httpClient.GetAsync(cafeUrl);
            var rawData = await response.Content.ReadAsStringAsync();

            cafeShops = JsonConvert.DeserializeObject<List<CafeShop>>(rawData);
            return cafeShops;
        }
    }
}

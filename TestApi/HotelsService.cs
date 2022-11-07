using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApi
{
    public class HotelsService
    {
        private string _API_KEY;

        public async Task<List<Hotel>> GetHotels()
        {
            var hotels = new List<Hotel>();
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://hotels-com-provider.p.rapidapi.com/v1/hotels/nearby?latitude=51.509865&currency=USD&longitude=-0.118092&checkout_date=2023-03-27&sort_order=STAR_RATING_HIGHEST_FIRST&checkin_date=2023-03-26&adults_number=1&locale=en_US&guest_rating_min=4&star_rating_ids=3%2C4%2C5&children_ages=4%2C0%2C15&page_number=1&price_min=10&accommodation_ids=20%2C8%2C15%2C5%2C1&theme_ids=14%2C27%2C25&price_max=500&amenity_ids=527%2C2063"),
                Headers =
                {
                    { "X-RapidAPI-Key", "5f2ec8d55dmsh061e3d0ab889ea7p1ffaf6jsnb8c8cc2c1b11" },
                    { "X-RapidAPI-Host", "hotels-com-provider.p.rapidapi.com" },
                },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var dynamicObject = JsonConvert.DeserializeObject<dynamic>(body)!;

                foreach (var result in dynamicObject["searchResults"]["results"])
                {
                    hotels.Add(new Hotel
                    {
                        Name = result["name"],
                        Price = result["ratePlan"]["price"]["current"]
                    });
                }
            }
            return hotels;
        }
    }
}

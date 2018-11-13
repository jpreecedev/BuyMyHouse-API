using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace BuyMyHouse_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListingsController : ControllerBase
    {
        private string _key;

        public ListingsController()
        {
            _key = Environment.GetEnvironmentVariable("API_KEY");
        }

        [HttpGet]
        public async Task<object> Get()
        {
            var client = new HttpClient();
            var url = $"https://api.zoopla.co.uk/api/v1/property_listings.json?radius=3&postcode=M3&area=Media%20City&api_key={_key}";
            Console.WriteLine(url);
            return await client.GetStringAsync(url);
        }
    }
}

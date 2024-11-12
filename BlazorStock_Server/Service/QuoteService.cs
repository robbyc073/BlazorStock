using BlazorStock_Server.Models;
using BlazorStock_Server.Service.IService;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Configuration;

namespace BlazorStock_Server.Service
{
    public class QuoteService : IQuoteService
    {

        private readonly IConfiguration _configuration;

        public QuoteService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<RootObject> GetQuote(string symbol)
        {
            try
            {

                symbol = symbol.Trim();
                var client = new HttpClient();
                var quote = new RootObject();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://twelve-data1.p.rapidapi.com/quote?symbol={symbol}&interval=5min&outputsize=30&format=json"),
                    Headers =
    {
        //Commented out to use App Service Env Variables instead
        //{ "X-RapidAPI-Key", _configuration["BlazorStockVariables:x-rapid-api-key"] },
        //{ "X-RapidAPI-Host", _configuration["BlazorStockVariables:x-rapid-api-host"] },
        { "X-RapidAPI-Key", Environment.GetEnvironmentVariable("x-rapid-api-key") },
        { "X-RapidAPI-Host", Environment.GetEnvironmentVariable("x-rapid-api-host") },
    },
                };
                Debug.WriteLine("Point one reached");
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var rootobject = JsonConvert.DeserializeObject<RootObject>(body);
                    return rootobject;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Debug.WriteLine("Exception begins here: " + ex.ToString());
                return new RootObject();
            }
        }
    }
}

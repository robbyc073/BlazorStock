using BlazorStock_Server.Models;
using static BlazorStock_Server.Models.TwelveDataQuote;

namespace BlazorStock_Server.Service.IService
{
    public interface IQuoteService
    {
        public Task <RootObject> GetQuote(string symbol);
    }
}

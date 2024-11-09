namespace BlazorStock_Server.Models
{
    [Serializable]
    public partial class TwelveDataQuote
    {
        public  RootObject? rootobject {get; set; }
        public class Fifty_Two_Week
        {
            public string? low { get; set; }
            public string? high { get; set; }
            public string? low_change { get; set; }
            public string? high_change { get; set; }
            public string? low_change_percent { get; set; }
            public string? high_change_percent { get; set; }
            public string? range { get; set; }
        }

    }
}

namespace BlazorStock_Server.Models
{
   
    
        [Serializable]
        public class RootObject
        {
            public string? symbol { get; set; }
            public string? name { get; set; }
            public string? exchange { get; set; }
            public string? mic_code { get; set; }
            public string? currency { get; set; }
            public string? datetime { get; set; }
            public int? timestamp { get; set; }
            public string? open { get; set; }
            public string? high { get; set; }
            public string? low { get; set; }
            public string? close { get; set; }
            public string? volume { get; set; }
            public string? previous_close { get; set; }
            public string? change { get; set; }
            public string? percent_change { get; set; }
            public string? average_volume { get; set; }
            public bool? is_market_open { get; set; }
            
        }

    
}

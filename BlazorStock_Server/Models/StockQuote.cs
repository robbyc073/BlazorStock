using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorStock.Server.Entities.Models
{
   public class StockQuote
   {
      public int? AvgTotalVolume { get; set; }
      public string? CalculationPrice { get; set; }
      public double? Change { get; set; }
      public double? ChangePercent { get; set; }
      public object? Close { get; set; }
      public string? CloseSource { get; set; }
      public object? CloseTime { get; set; }
      public string? CompanyName { get; set; }
      public string? Currency { get; set; }
      public object? DelayedPrice { get; set; }
      public object? DelayedPriceTime { get; set; }
      public object? ExtendedChange { get; set; }
      public object? ExtendedChangePercent { get; set; }
      public object? ExtendedPrice { get; set; }
      public object? ExtendedPriceTime { get; set; }
      public object? High { get; set; }
      public object? HighSource { get; set; }
      public object? HighTime { get; set; }
      public double? IexAskPrice { get; set; }
      public double? IexAskSize { get; set; }
      public double? IexBidPrice { get; set; }
      public double? IexBidSize { get; set; }
      public double? IexClose { get; set; }
      public long? IexCloseTime { get; set; }
      public long? IexLastUpdated { get; set; }
      public double? IexMarketPercent { get; set; }
      public double? IexOpen { get; set; }
      public long? IexOpenTime { get; set; }
      public double? IexRealtimePrice { get; set; }
      public int? IexRealtimeSize { get; set; }
      public int? IexVolume { get; set; }
      public long? LastTradeTime { get; set; }
      public double? LatestPrice { get; set; }
      public string? LatestSource { get; set; }
      public string? LatestTime { get; set; }
      public long? LatestUpdate { get; set; }
      public object? LatestVolume { get; set; }
      public object? Low { get; set; }
      public string? LowSource { get; set; }
      public long? LowTime { get; set; }
      public long? MarketCap { get; set; }
      public object? OddLotDelayedPrice { get; set; }
      public object? OddLotDelayedPriceTime { get; set; }
      public object? Open { get; set; }
      public object? OpenTime { get; set; }
      public string? OpenSource { get; set; }
      public double? PeRatio { get; set; }
      public double? PreviousClose { get; set; }
      public int? PreviousVolume { get; set; }
      public string? PrimaryExchange { get; set; }
      public string? Symbol { get; set; }
      public object? Volume { get; set; }
      public double? Week52High { get; set; }
      public double? Week52Low { get; set; }
      public double? YtdChange { get; set; }
      public bool? IsUSMarketOpen { get; set; }
      public string? ErrorMessage { get; set; }
   }
}

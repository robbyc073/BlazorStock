using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorStock.Server.Entities.Models
{
    public class StockTransactionDTO
    {
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        [Required]
        public string Symbol { get; set; } = null!;
        [Required]
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string TransactionType { get; set; } = null!;
        //public DateTime TimeStamp { get; set; }

        //public virtual StockUser User { get; set; } = null!;
    }
}

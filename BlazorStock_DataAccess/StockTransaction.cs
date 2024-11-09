using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorStock_DataAccess
{
    public partial class StockTransaction
    {
        [Key]
        public int TransactionId { get; set; }
        public int UserId { get; set; }
        public string Symbol { get; set; } = null!;
        public int Quantity { get; set; }
        public double Price { get; set; }
        public double Total { get; set; }
        public string TransactionType { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public virtual StockUser User { get; set; } = null!;
    }
}

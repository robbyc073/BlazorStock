using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlazorStock_DataAccess
{
    public partial class StockUser
    {
        public StockUser()
        {
            StockTransactions = new HashSet<StockTransaction>();
        }
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string UserEmail { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        public string FullName { get; set; } = null!;
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<StockTransaction> StockTransactions { get; set; }
    }
}

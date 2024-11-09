using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorStock.Server.Entities.Models
{
    public class StockUserDTO
    {

        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; } = null!;
        [Required]
        public string UserEmail { get; set; } = null!;
        public string PasswordHash { get; set; } = null!;
        [Required]
        public string FullName { get; set; } = null!;

    }
}

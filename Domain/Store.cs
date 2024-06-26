using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Store
    {
        public Store()
        {
            Prices = new List<Price>();
            Transactions = new List<Transaction>();
            LogoImageUrl = string.Empty; 
            Name = string.Empty; 
            Url = string.Empty; 
        
        }

        [Key]
        public int StoreId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Url]
        public string Url { get; set; }

        [MaxLength(500)]
        public string LogoImageUrl { get; set; }

        public List<Price> Prices { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}

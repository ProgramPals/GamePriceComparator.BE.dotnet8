using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Price
    {
        public Price()
        {
            Currency = String.Empty;
            Game = new Game();
            Store = new Store();
        
        }


        [Key]
        public int PriceId { get; set; }

        [Required]
        public int GameId { get; set; }

        [Required]
        public int StoreId { get; set; }

        [Required]
        public decimal GamePrice { get; set; }

        [Required]
        [MaxLength(10)]
        public string Currency { get; set; }

        public DateTime PriceUpdatedAt { get; set; } = DateTime.UtcNow;

        public Game Game { get; set; }
        public Store Store { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class PriceAlert
    {
        public PriceAlert()
        {
            User = new User();
            Game = new Game();
        }


        [Key]
        public int AlertId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int GameId { get; set; }

        [Required]
        public decimal DesiredPrice { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Game Game { get; set; }
    }
}

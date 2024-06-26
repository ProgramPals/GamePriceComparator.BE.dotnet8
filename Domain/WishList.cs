using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Wishlist
    {
        public Wishlist()
        {
            User = new User();
            Game = new Game();
        }
        [Key]
        public int WishlistId { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int GameId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Game Game { get; set; }
    }
}

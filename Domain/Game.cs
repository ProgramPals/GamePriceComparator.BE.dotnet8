using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Game
    {
        public Game()
        {
            Genres = new List<Genre>();
            Platforms = new List<Platform>();
            GalleryImageUrls = new List<string>();
            GameImages = new List<GameImage>();
            Prices = new List<Price>();
            Wishlists = new List<Wishlist>();
            PriceAlerts = new List<PriceAlert>();
            Reviews = new List<Review>();
            Transactions = new List<Transaction>();
            Title = string.Empty;
            Developer = string.Empty;
            Publisher = string.Empty;
            Description = string.Empty;
        }

        [Key]
        public int GameId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Title { get; set; }

        public List<Genre> Genres { get; set; }
        public List<Platform> Platforms { get; set; }
        public DateTime ReleaseDate { get; set; }

        [MaxLength(255)]
        public string Developer { get; set; }

        [MaxLength(255)]
        public string Publisher { get; set; }

        public string Description { get; set; }

        public List<string> GalleryImageUrls { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public List<GameImage> GameImages { get; set; }
        public List<Price> Prices { get; set; }
        public List<Wishlist> Wishlists { get; set; }
        public List<PriceAlert> PriceAlerts { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}

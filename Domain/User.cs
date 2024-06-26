using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class User
    {
        public User()
        {
            Wishlists = new List<Wishlist>();
            PriceAlerts = new List<PriceAlert>();
            Reviews = new List<Review>();
            Transactions = new List<Transaction>();
            Username = string.Empty; // Initialize to empty string
            Email = string.Empty; // Initialize to empty string
            Password = string.Empty; // Initialize to empty string
            ProfileImageUrl = string.Empty; // Initialize to empty string
        }

        [Key]
        public int UserId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [MaxLength(500)]
        public string ProfileImageUrl { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public List<Wishlist> Wishlists { get; set; }
        public List<PriceAlert> PriceAlerts { get; set; }
        public List<Review> Reviews { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}

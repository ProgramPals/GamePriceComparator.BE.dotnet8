using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain;
public class User
{
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


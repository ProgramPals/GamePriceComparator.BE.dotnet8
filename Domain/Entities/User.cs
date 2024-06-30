using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class User : BaseAuditableEntity
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

    public List<Wishlist> Wishlists { get; set; }
    public List<PriceAlert> PriceAlerts { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Transaction> Transactions { get; set; }
}


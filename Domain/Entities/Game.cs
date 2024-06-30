using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Game : BaseAuditableEntity
{
    [Key]
    public int GameId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Title { get; set; }

    [Required]
    public List<Genre> Genres { get; set; } = new List<Genre>();

    [Required]
    public List<Platform> Platforms { get; set; } = new List<Platform>();

    public DateTime ReleaseDate { get; set; }

    [MaxLength(255)]
    public string Developer { get; set; }

    [MaxLength(255)]
    public string Publisher { get; set; }

    public string Description { get; set; }

    [MaxLength(500)]
    public string CoverImageUrl { get; set; }

    public List<string> GalleryImageUrls { get; set; } = new List<string>();

    public List<GameImage> GameImages { get; set; }
    public List<Price> Prices { get; set; }
    public List<Wishlist> Wishlists { get; set; }
    public List<PriceAlert> PriceAlerts { get; set; }
    public List<Review> Reviews { get; set; }
    public List<Transaction> Transactions { get; set; }
}

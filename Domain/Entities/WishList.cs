using System;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Wishlist : BaseAuditableEntity
{
    [Key]
    public int WishlistId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int GameId { get; set; }

    public User User { get; set; }
    public Game Game { get; set; }
}

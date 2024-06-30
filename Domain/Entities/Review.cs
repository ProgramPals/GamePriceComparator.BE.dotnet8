using System;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Review : BaseAuditableEntity
{
    [Key]
    public int ReviewId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int GameId { get; set; }

    [Required]
    [Range(1, 5)]
    public int Rating { get; set; }

    public string ReviewText { get; set; }

    public User User { get; set; }
    public Game Game { get; set; }
}

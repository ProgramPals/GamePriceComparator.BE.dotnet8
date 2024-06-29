using System;
using System.ComponentModel.DataAnnotations;
namespace Domain;
public class PriceAlert
{
    [Key]
    public int AlertId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int GameId { get; set; }

    [Required]
    public decimal DesiredPrice { get; set; }

    public User User { get; set; }
    public Game Game { get; set; }
}

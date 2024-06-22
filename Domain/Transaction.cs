using System;
using System.ComponentModel.DataAnnotations;
namespace Domain;
public class Transaction
{
    [Key]
    public int TransactionId { get; set; }

    [Required]
    public int UserId { get; set; }

    [Required]
    public int GameId { get; set; }

    [Required]
    public int StoreId { get; set; }

    [Required]
    public decimal GamePrice { get; set; }

    [Required]
    [MaxLength(10)]
    public string Currency { get; set; }

    public DateTime TransactionDate { get; set; } = DateTime.UtcNow;

    public User User { get; set; }
    public Game Game { get; set; }
    public Store Store { get; set; }
}

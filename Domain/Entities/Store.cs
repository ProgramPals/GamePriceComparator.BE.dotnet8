using System;
using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;
public class Store : BaseAuditableEntity
{
    [Key]
    public int StoreId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    [Required]
    [Url]
    public string Url { get; set; }

    [MaxLength(500)]
    public string LogoImageUrl { get; set; }
}

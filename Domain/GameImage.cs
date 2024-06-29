using System;
using System.ComponentModel.DataAnnotations;
namespace Domain;
public class GameImage : AuditableEntity
{
    [Key]
    public int ImageId { get; set; }

    [Required]
    public int GameId { get; set; }

    [Required]
    [Url]
    public string ImageUrl { get; set; }

    [Required]
    [MaxLength(50)]
    public string ImageType { get; set; }  // e.g., 'cover', 'screenshot'

    public Game Game { get; set; }
}

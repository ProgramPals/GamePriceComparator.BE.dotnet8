using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class Genre : BaseAuditableEntity
{
    [Key]
    public int GenreId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    public string Description { get; set; }
}

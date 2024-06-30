using System.ComponentModel.DataAnnotations;
namespace Domain.Entities;

public class Platform : BaseAuditableEntity
{
    [Key]
    public int PlatformId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    public string Description { get; set; }
}

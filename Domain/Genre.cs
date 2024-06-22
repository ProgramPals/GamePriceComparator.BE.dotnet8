using System.ComponentModel.DataAnnotations;
namespace Domain;

public class Genre
{
    [Key]
    public int GenreId { get; set; }

    [Required]
    [MaxLength(255)]
    public string Name { get; set; }

    public string Description { get; set; }
}
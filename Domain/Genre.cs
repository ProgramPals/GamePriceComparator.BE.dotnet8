using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Genre
    {
        public Genre()
        {
            Games = new List<Game>();
            Description = String.Empty;
            Name = String.Empty;
        }


        [Key]
        public int GenreId { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public List<Game> Games { get; set; } 
    }
}

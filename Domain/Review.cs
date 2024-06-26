using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class Review
    {
        public Review()
        {
            User = new User();
            Game = new Game();
            ReviewText = String.Empty;
        }


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

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;

        public User User { get; set; }
        public Game Game { get; set; }
    }
}

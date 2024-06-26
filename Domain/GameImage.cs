using System;
using System.ComponentModel.DataAnnotations;

namespace Domain
{
    public class GameImage
    {
        public GameImage()
        {
            ImageUrl = String.Empty;
            ImageType = String.Empty;
            Game = new Game();
            ImageData = new byte[0];

        }

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

        [Required]
        public byte[] ImageData { get; set; }

        public DateTime UploadedAt { get; set; } = DateTime.UtcNow;

        public Game Game { get; set; } 
    }
}

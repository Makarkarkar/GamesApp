
using System.ComponentModel.DataAnnotations;

namespace GamesApp.Models
{
    public  class Games
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DevStudio { get; set; }
        
        
        
    }
}

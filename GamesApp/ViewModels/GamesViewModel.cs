
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GamesApp.ViewModels
{
    public class GamesViewModel
    {
        public GamesViewModel()
        {
            Genres = new HashSet<Models.Genres>();
        }
        [Required]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DevStudio { get; set; }

        public IEnumerable<Models.Genres> Genres { get; set; }
        
    }
}
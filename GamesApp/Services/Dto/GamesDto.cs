using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using GamesApp.Models;

namespace GamesApp.Services.Dto
{
    public class GamesDto
    {
        public GamesDto()
        {
            Genres = new HashSet<Models.Genres>();
            // AllGenres = new HashSet<Models.Genres>();
        }
        [Required]
        public int GameId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string DevStudio { get; set; }
        public IEnumerable<Genres> Genres { get; set; }
        // public IEnumerable<Genres> AllGenres { get; set; }
    }
}
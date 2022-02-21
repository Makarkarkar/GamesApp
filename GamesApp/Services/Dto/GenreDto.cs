using System.Collections.Generic;
using GamesApp.Models;

namespace GamesApp.Services.Dto
{
    public class GenreDto
    {
        public GenreDto()
        {
            Games = new HashSet<Models.Games>();
            // AllGames = new HashSet<Models.Games>();
        }
        public int GenreId { get; set; }
        public string GenreName { get; set; }
        public IEnumerable<Games> Games { get; set; }
        
    }
}